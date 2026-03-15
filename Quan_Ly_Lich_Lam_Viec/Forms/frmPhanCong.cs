using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;
using System.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmPhanCong : Form
    {
        private int? _maLichTruyenSang = null;
        private bool? them = false;

        public frmPhanCong(int? maLich = null, bool them = false)
        {
            InitializeComponent();
            this._maLichTruyenSang = maLich;
            this.them = them;
            LoadData();

        }

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource pcBindingSource = new BindingSource();
        bool xuLyThem = false; // Cờ kiểm tra trạng thái


        private void LoadData()
        {
            context = new Quan_Li_Lich_Lam_DbContext();

            // Load ComboBox
            cboLichLamViec.DataSource = context.Lich_Lam_Viec.ToList();
            cboLichLamViec.DisplayMember = "TieuDe";
            cboLichLamViec.ValueMember = "MaLich";

            cboNhanVien.DataSource = context.Nhan_Vien.ToList();
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNhanVien";

            // Load Grid kèm Include để cột ảo hoạt động
            var listPC = context.Chi_Tiet_Phan_Cong
                                .Include(p => p.Nhan_Vien)
                                .Include(p => p.Lich_Lam_Viec)
                                .Where(ct => ct.MaLich == _maLichTruyenSang)
                                .ToList();

            pcBindingSource.DataSource = listPC;
            dataGridView.DataSource = pcBindingSource;


            ThietLapBinding();
            SetupGrid();

        }

        private void SetupGrid()
        {
            // Ẩn các cột ID và quan hệ
            string[] hideCols = { "MaPhanCong", /*"MaNhanVien",*/ "Nhan_Vien", "Lich_Lam_Viec" };
            foreach (var col in hideCols)
                if (dataGridView.Columns[col] != null) dataGridView.Columns[col].Visible = false;


        }

        private void ThietLapBinding()
        {
            if (cboVaiTro.DataBindings.Count > 0) return;

            cboVaiTro.DataBindings.Add("Text", pcBindingSource, "Vai_Tro", true, DataSourceUpdateMode.OnPropertyChanged);
            chkXacNhan.DataBindings.Add("Checked", pcBindingSource, "Da_Xac_Nhan", true, DataSourceUpdateMode.OnPropertyChanged);
            cboLichLamViec.DataBindings.Add("SelectedValue", pcBindingSource, "MaLich", true, DataSourceUpdateMode.OnPropertyChanged);
            cboNhanVien.DataBindings.Add("SelectedValue", pcBindingSource, "MaNhanVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BatTatChucNang(bool bat)
        {
            btnLuu.Enabled = bat;
            btnHuyBo.Enabled = bat;

            cboLichLamViec.Enabled = bat;
            cboNhanVien.Enabled = bat;
            cboVaiTro.Enabled = bat;
            // Người dùng vẫn có thể tự nhập thêm vai trò mới ngoài list
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDown;
            if (bat == true)
            {
                // Nếu đang mở để nhập và vai trò đang là Chủ trì thì khóa Checkbox
                if (cboVaiTro.Text == "Chủ trì") chkXacNhan.Enabled = false;
                else chkXacNhan.Enabled = true;
            }
            else
            {
                chkXacNhan.Enabled = false; // Luôn khóa khi không ở chế độ Thêm/Sửa
            }
            chkXacNhan.Enabled = bat;
            btnThem.Enabled = !bat;
            btnSua.Enabled = !bat;
            btnXoa.Enabled = !bat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true); // Hàm này thường mở hết tất cả các ô

            // NẾU có mã lịch truyền sang thì phải khóa lại ngay sau khi hàm BatTatChucNang vừa mở nó ra
            if (them == true)
            {
                cboLichLamViec.Enabled = false;
            }

            pcBindingSource.AddNew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xóa phân công này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaPhanCong"].Value);
                var pc = context.Chi_Tiet_Phan_Cong.Find(id);
                if (pc != null)
                {
                    context.Chi_Tiet_Phan_Cong.Remove(pc);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ giao diện
                int maNV = (int)cboNhanVien.SelectedValue;
                int maLich = (int)cboLichLamViec.SelectedValue;
                string vaiTro = cboVaiTro.Text.Trim();
                bool xacNhan = chkXacNhan.Checked;

                // Tự động xác nhận cho Chủ trì
                if (vaiTro == "Chủ trì") xacNhan = true;

                if (xuLyThem) // TRƯỜNG HỢP THÊM MỚI
                {
                    // Bước A: Kiểm tra xem nhân viên này đã có trong lịch này chưa
                    if (context.Chi_Tiet_Phan_Cong.Any(x => x.MaLich == maLich && x.MaNhanVien == maNV))
                    {
                        MessageBox.Show("Nhân viên này đã có trong danh sách phân công của lịch này!", "Thông báo");
                        return;
                    }

                    // Bước B: Kiểm tra xung đột thời gian (Điểm cộng thực tế)
                    if (KiemTraXungDotThoiGian(maNV, maLich)) return;

                    // Bước C: Tạo mới object và thêm vào context
                    Chi_Tiet_Phan_Cong pcMoi = new Chi_Tiet_Phan_Cong
                    {
                        MaNhanVien = maNV,
                        MaLich = maLich,
                        Vai_Tro = vaiTro,
                        Da_Xac_Nhan = xacNhan
                    };
                    context.Chi_Tiet_Phan_Cong.Add(pcMoi);
                }
                else // TRƯỜNG HỢP SỬA
                {
                    if (dataGridView.CurrentRow == null) return;
                    int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaPhanCong"].Value);

                    // Kiểm tra xung đột thời gian khi sửa (trừ chính bản ghi này)
                    if (KiemTraXungDotThoiGian(maNV, maLich, id)) return;

                    // Tìm bản ghi cũ trong DB
                    var pcSua = context.Chi_Tiet_Phan_Cong.Find(id);
                    if (pcSua != null)
                    {
                        pcSua.MaNhanVien = maNV;
                        pcSua.MaLich = maLich;
                        pcSua.Vai_Tro = vaiTro;
                        pcSua.Da_Xac_Nhan = xacNhan;
                        context.Chi_Tiet_Phan_Cong.Update(pcSua);
                    }
                }

                // 3. Lưu xuống Database
                context.SaveChanges();

                // 4. Cập nhật lại giao diện
                LoadData();
                BatTatChucNang(false);
                MessageBox.Show("Cập nhật phân công thành công!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }


        private bool KiemTraXungDotThoiGian(int maNhanVien, int maLichMoi, int? maPhanCongHienTai = null)
        {
            // Lấy thông tin thời gian của lịch mới đang định phân công
            var lichMoi = context.Lich_Lam_Viec.Find(maLichMoi);
            if (lichMoi == null) return false;

            DateTime s1 = lichMoi.ThoiGianBatDau;
            DateTime e1 = lichMoi.ThoiGianKetThuc;

            // Tìm tất cả các phân công của nhân viên này (trừ bản ghi đang sửa nếu có)
            var dsLichDaPhan = context.Chi_Tiet_Phan_Cong
                .Where(pc => pc.MaNhanVien == maNhanVien && pc.MaPhanCong != maPhanCongHienTai)
                .Select(pc => new
                {
                    pc.Lich_Lam_Viec.ThoiGianBatDau,
                    pc.Lich_Lam_Viec.ThoiGianKetThuc,
                    pc.Lich_Lam_Viec.TieuDe
                })
                .ToList();

            // Duyệt danh sách để kiểm tra giao thoa thời gian
            foreach (var lichCu in dsLichDaPhan)
            {
                DateTime s2 = lichCu.ThoiGianBatDau;
                DateTime e2 = lichCu.ThoiGianKetThuc;

                // Công thức kiểm tra giao thoa
                if (s1 < e2 && s2 < e1)
                {
                    MessageBox.Show($"Nhân viên này đã có lịch '{lichCu.TieuDe}' \n" +
                                    $"từ {s2:dd/MM HH:mm} đến {e2:dd/MM HH:mm}.\n" +
                                    $"Vui lòng chọn khung giờ khác!", "Xung đột thời gian",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true; // Bị trùng
                }
            }

            return false; // Không trùng
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu vai trò là "Chủ trì"
            if (cboVaiTro.Text.Trim() == "Chủ trì" || cboVaiTro.Text.Trim() == "Trưởng nhóm")
            {
                chkXacNhan.Checked = true;
                // Có thể khóa luôn checkbox này vì Chủ trì thì mặc nhiên phải tham gia
                chkXacNhan.Enabled = false;
            }
            else
            {
                // Nếu chọn vai trò khác thì trả lại quyền tích chọn cho người dùng
                chkXacNhan.Enabled = true;
            }
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(_maLichTruyenSang.ToString());
            LoadData();
            BatTatChucNang(false);

            if (them == true)
            {
                // 1. Gọi trực tiếp hàm Thêm để mở khóa các ô nhập liệu và chuẩn bị Binding
                btnThem_Click(sender, e);

                // 2. Gán mã lịch đã truyền sang
                cboLichLamViec.SelectedValue = _maLichTruyenSang;

                // 3. Khóa cứng ComboBox lịch lại để không cho chọn lịch khác
                cboLichLamViec.Enabled = false;

                // 4. Nhảy con trỏ xuống ô Nhân viên để người dùng chọn luôn cho nhanh
                cboNhanVien.Focus();
            }

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dataGridView.Columns[e.ColumnIndex].Name == "MaNhanVien" && e.Value != null)
            {
                // Thay vì hiện số ID, ta hiện tên loại
                var id = (int)e.Value;
                var item = context.Nhan_Vien.Find(id);
                if (item != null) e.Value = item.HoTen;
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "MaLich" && e.Value != null)
            {
                // Thay vì hiện số ID, ta hiện tên loại
                var id = (int)e.Value;
                var item = context.Lich_Lam_Viec.Find(id);
                if (item != null) e.Value = item.TieuDe;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppendLog(string message, bool isSuccess, ListBox lstLog)
        {
            string status = isSuccess ? "thành công" : "thất bại";
            lstLog.Items.Add($"{message} - {status}");
            lstLog.SelectedIndex = lstLog.Items.Count - 1; // Cuộn xuống dòng mới nhất
        }
    }
}

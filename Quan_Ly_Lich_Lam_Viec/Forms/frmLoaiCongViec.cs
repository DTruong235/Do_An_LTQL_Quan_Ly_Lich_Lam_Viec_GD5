using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmLoaiCongViec : Form
    {
        public frmLoaiCongViec()
        {
            InitializeComponent();
        }

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource lcvBindingSource = new BindingSource();
        bool xuLyThem = false;

        private void frmLoaiCongViec_Load(object sender, EventArgs e)
        {
            LoadData();
            BatTatChucNang(false);
        }

        private void LoadData()
        {
            context = new Quan_Li_Lich_Lam_DbContext();
            var list = context.Loai_Cong_Viec.ToList();

            lcvBindingSource.DataSource = list;
            dataGridView.DataSource = lcvBindingSource;

            ThietLapBinding();
        }

        private void ThietLapBinding()
        {
            txtTenLoai.DataBindings.Clear();

            txtTenLoai.DataBindings.Add("Text", lcvBindingSource, "TenLoai", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BatTatChucNang(bool bat)
        {
            btnLuu.Enabled = bat;
            btnHuyBo.Enabled = bat;
            txtTenLoai.Enabled = bat;

            btnThem.Enabled = !bat;
            btnSua.Enabled = !bat;
            btnXoa.Enabled = !bat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            lcvBindingSource.AddNew();
            txtTenLoai.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra đầu vào cực kỳ cơ bản
                if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
                {
                    MessageBox.Show("Tên loại công việc không được để trống!");
                    txtTenLoai.Focus();
                    return;
                }

                // 2. Xác định đối tượng thao tác từ BindingSource
                lcvBindingSource.EndEdit();
                var lcv = (Loai_Cong_Viec)lcvBindingSource.Current;

                // Cập nhật giá trị mới nhất từ TextBox vào Object (Đảm bảo dữ liệu mới nhất để check)
                lcv.TenLoai = txtTenLoai.Text.Trim();

                // 3. KIỂM TRA NGHIỆP VỤ (Gọi hàm dùng chung cho cả Form và Import)
                string loi = KiemTraHopLe(lcv, xuLyThem);
                if (!string.IsNullOrEmpty(loi))
                {
                    MessageBox.Show(loi, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4. Thực hiện lưu
                if (xuLyThem)
                {
                    context.Loai_Cong_Viec.Add(lcv);
                }
                else
                {
                    // Đối với Sửa, EF thường đã theo dõi đối tượng qua BindingSource
                    // Nhưng ép trạng thái Modified để đảm bảo an toàn
                    context.Entry(lcv).State = EntityState.Modified;
                }

                context.SaveChanges();

                // 5. Hậu xử lý
                MessageBox.Show(xuLyThem ? "Thêm mới thành công!" : "Cập nhật thành công!", "Thông báo");

                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private string KiemTraHopLe(Loai_Cong_Viec lcv, bool isThemMoi)
        {

            // Kiểm tra trùng tên
            bool biTrungTen = context.Loai_Cong_Viec.Any(l => l.TenLoai == lcv.TenLoai.Trim()
                              && (isThemMoi || l.MaLoaiCV != lcv.MaLoaiCV));

            if (biTrungTen) return "Tên loại công việc này đã tồn tại!";

            return ""; // Hợp lệ
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lcvBindingSource.Current == null) return;

            var item = (Loai_Cong_Viec)lcvBindingSource.Current;

            // --- KIỂM TRA RÀNG BUỘC (CONSTRAINT) ---
            // Không cho xóa nếu đã có lịch sử dụng loại công việc này
            bool dangDung = context.Lich_Lam_Viec.Any(l => l.MaLoaiCV == item.MaLoaiCV);
            if (dangDung)
            {
                MessageBox.Show("Không thể xóa loại này vì đã có lịch làm việc sử dụng nó!", "Cảnh báo");
                return;
            }

            if (MessageBox.Show("Xác nhận xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Loai_Cong_Viec.Remove(item);
                context.SaveChanges();
                LoadData();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            lcvBindingSource.CancelEdit();
            LoadData();
            BatTatChucNang(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (lcvBindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn loại công việc cần sửa từ danh sách!");
                return;
            }

            xuLyThem = false; // Đặt cờ là Đang Sửa
            BatTatChucNang(true); // Mở khóa các ô txtTenLoai, txtMoTa
            txtTenLoai.Focus(); // Đưa con trỏ vào ô tên để sửa luôn
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ImportLoaiCV(string filePath, ListBox lstLog)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        int soDongThanhCong = 0, soDongThatBai = 0;
                        lstLog.Visible = true;
                        lstLog.Items.Clear();

                        var ws = workbook.Worksheet(1);
                        var rows = ws.RowsUsed().Skip(1);

                        foreach (var row in rows)
                        {
                            try
                            {
                                string tenLoai = row.Cell(2).GetValue<string>();
                                if (string.IsNullOrWhiteSpace(tenLoai)) continue;

                                var lcv = new Loai_Cong_Viec { TenLoai = tenLoai.Trim() };

                                // Kiểm tra hợp lệ (Trùng tên...)
                                string loi = KiemTraHopLe(lcv, true);
                                if (loi == "")
                                {
                                    context.Loai_Cong_Viec.Add(lcv);
                                    context.SaveChanges();
                                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ Nhập: {tenLoai} - thành công");
                                    soDongThanhCong++;
                                }
                                else
                                {
                                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ❌ Dòng {row.RowNumber()}: {loi}");
                                    soDongThatBai++;
                                }
                                lstLog.TopIndex = lstLog.Items.Count - 1;
                                Application.DoEvents();
                            }
                            catch (Exception ex)
                            {
                                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ❌ Dòng {row.RowNumber()}: {ex.Message}");
                                soDongThatBai++;
                            }
                        }
                        transaction.Commit();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ NHẬP NHÂN VIÊN HOÀN TẤT!");

                        if (soDongThatBai == 0)
                        {
                            MessageBox.Show($"Đã nhập hoàn tất thành công {soDongThanhCong} dòng!",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Quá trình nhập không thành công hoàn toàn!\n" +
                                $"- Thành công: {soDongThanhCong}\n" +
                                $"- Thất bại: {soDongThatBai}\n" +
                                $"Vui lòng kiểm tra lại danh sách Log.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                    }
                }
            }
        }

        public void ExportLoaiCV(string filePath, ListBox lstLog)
        {
            try
            {
                lstLog.Visible = true;
                lstLog.Items.Clear();
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu xuất danh mục loại công việc...");

                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Loai Cong Viec");
                    ws.Cell(1, 1).Value = "Mã Loại";
                    ws.Cell(1, 2).Value = "Tên Loại Công Việc";
                    ws.Row(1).Style.Font.Bold = true;

                    var list = context.Loai_Cong_Viec.ToList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        ws.Cell(i + 2, 1).Value = list[i].MaLoaiCV;
                        ws.Cell(i + 2, 2).Value = list[i].TenLoai;

                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang xuất: {list[i].TenLoai} - thành công");
                        lstLog.TopIndex = lstLog.Items.Count - 1;
                        Application.DoEvents();
                    }

                    ws.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);
                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ XUẤT FILE NHÂN VIÊN HOÀN TẤT!");
                    MessageBox.Show("Xuất danh sách nhân viên thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                grBoxDanhSachLog.Visible = true;

                string filePath = openFileDialog.FileName;
                ImportLoaiCV(filePath, lstLog);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "LoaiCongViec_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                grBoxDanhSachLog.Visible = true;

                string filePath = saveFileDialog.FileName;
                ExportLoaiCV(filePath, lstLog);
            }
        }
    }
}



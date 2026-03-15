using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Quan_Ly_Lich_Lam_Viec.Data;


namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource nvBindingSource = new BindingSource();
        bool xuLyThem = false; // Cờ kiểm tra đang thêm hay sửa



        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            // Vùng nhập liệu
            txtHoVaTen.Enabled = giaTri;
            txtEmail.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            cboMaPhong.Enabled = giaTri;
            cboMaChucVu.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;

            // Các nút thao tác
            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false); // Mặc định khóa nhập liệu [cite: 74]
            LoadData();
        }

        private void LoadData()
        {
            // Làm mới context để cập nhật dữ liệu mới nhất
            context = new Quan_Li_Lich_Lam_DbContext();

            // 2. Load dữ liệu cho ComboBox
            cboMaPhong.DataSource = context.Phong_Ban.ToList();
            cboMaPhong.DisplayMember = "TenPhong";
            cboMaPhong.ValueMember = "MaPhong";

            cboMaChucVu.DataSource = context.Chuc_Vu.ToList();
            cboMaChucVu.DisplayMember = "TenChucVu";
            cboMaChucVu.ValueMember = "MaChucVu";

            // 3. Load danh sách nhân viên kèm theo bảng liên quan để hiển thị tên trên Grid
            var listNV = context.Nhan_Vien
                                .Include(n => n.Phong_Ban)
                                .Include(n => n.Chuc_Vu)
                                .ToList();

            nvBindingSource.DataSource = context.Nhan_Vien.Local.ToBindingList();
            dataGridView.DataSource = nvBindingSource;

            // 4. Thiết lập Binding
            ThietLapBinding();

            // 5. Cấu hình ẩn cột ID và cột quan hệ trên Grid
            string[] colToHide = { "MaNhanVien", "Phong_Ban", "Chuc_Vu", "Tai_Khoan", "Chi_Tiet_Phan_Cong" };
            foreach (var col in colToHide)
            {
                if (dataGridView.Columns[col] != null) dataGridView.Columns[col].Visible = false;
            }
        }

        private void ThietLapBinding()
        {
            // Ngăn chặn việc add binding nhiều lần gây lỗi duplicate
            if (txtHoVaTen.DataBindings.Count > 0) return;

            // Binding thông minh với DataSourceUpdateMode.OnPropertyChanged
            txtHoVaTen.DataBindings.Add("Text", nvBindingSource, "HoTen", true, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", nvBindingSource, "Email", true, DataSourceUpdateMode.OnPropertyChanged);
            txtSDT.DataBindings.Add("Text", nvBindingSource, "SoDienThoai", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Add("Text", nvBindingSource, "DiaChi", true, DataSourceUpdateMode.OnPropertyChanged);
            dtpNgaySinh.DataBindings.Add("Value", nvBindingSource, "NgaySinh", true, DataSourceUpdateMode.OnPropertyChanged);

            cboMaPhong.DataBindings.Add("SelectedValue", nvBindingSource, "MaPhong", true, DataSourceUpdateMode.OnPropertyChanged);
            cboMaChucVu.DataBindings.Add("SelectedValue", nvBindingSource, "MaChucVu", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true); // Mở khóa nhập liệu

            nvBindingSource.AddNew();
            var newNV = (Nhan_Vien)nvBindingSource.Current;

            // Xóa trắng các ô để nhập mới
            txtHoVaTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            cboMaPhong.SelectedIndex = -1;
            cboMaChucVu.SelectedIndex = -1;
            txtDiaChi.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true); // Mở khóa để sửa
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["MaNhanVien"].Value);
                Nhan_Vien nv = context.Nhan_Vien.Find(id);
                if (nv != null)
                {
                    context.Nhan_Vien.Remove(nv);
                    context.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào (Input Validation)
                if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                {
                    MessageBox.Show("Họ tên nhân viên không được để trống!");
                    txtHoVaTen.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email không được để trống!");
                    txtEmail.Focus();
                    return;
                }

                // Kiểm tra nghiệp vụ (Business Validation)
                int maNVHienTai = xuLyThem ? 0 : Convert.ToInt32(dataGridView.CurrentRow.Cells["MaNhanVien"].Value);
                string emailMoi = txtEmail.Text.Trim();
                string sdtMoi = txtSDT.Text.Trim();

                // Khởi tạo object tạm để dùng hàm KiemTraHopLe
                Nhan_Vien nvTam = new Nhan_Vien
                {
                    MaNhanVien = maNVHienTai,
                    HoTen = txtHoVaTen.Text.Trim(),
                    Email = emailMoi,
                    SoDienThoai = sdtMoi,
                    NgaySinh = dtpNgaySinh.Value
                };

                string loi = KiemTraHopLe(nvTam, xuLyThem);
                if (!string.IsNullOrEmpty(loi))
                {
                    MessageBox.Show(loi, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Thực hiện lưu
                Nhan_Vien nv;
                if (xuLyThem)
                {
                    nv = new Nhan_Vien();
                    context.Nhan_Vien.Add(nv);
                }
                else
                {
                    nv = context.Nhan_Vien.Find(maNVHienTai);
                    if (nv == null) return;
                }

                // Gán dữ liệu vào object chính thức
                nv.HoTen = nvTam.HoTen;
                nv.Email = nvTam.Email;
                nv.SoDienThoai = nvTam.SoDienThoai;
                nv.NgaySinh = nvTam.NgaySinh;
                nv.MaPhong = (int)cboMaPhong.SelectedValue;
                nv.MaChucVu = (int)cboMaChucVu.SelectedValue;
                nv.DiaChi = txtDiaChi.Text.Trim();

                context.SaveChanges();

                // 4. Hậu xử lý (Tương tự Form Lịch)
                MessageBox.Show("Lưu thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Bạn có thể thêm logic hậu xử lý ở đây, ví dụ: 
                // Hỏi xem có muốn cấp tài khoản đăng nhập ngay không, v.v.

                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private string KiemTraHopLe(Nhan_Vien nv, bool isThemMoi)
        {

            // Kiểm tra định dạng Email
            try
            {
                var addr = new System.Net.Mail.MailAddress(nv.Email);
                if (addr.Address != nv.Email.Trim()) return "Định dạng Email không hợp lệ!";
            }
            catch { return "Định dạng Email không hợp lệ!"; }

            // Kiểm tra trùng Email
            // Nếu thêm mới: tìm bất kỳ ai trùng email
            // Nếu sửa: tìm người trùng email nhưng không phải là chính mình (nv.MaNhanVien)
            bool biTrungEmail = context.Nhan_Vien.Any(n => n.Email == nv.Email && (isThemMoi || n.MaNhanVien != nv.MaNhanVien));
            if (biTrungEmail) return "Email này đã tồn tại trong hệ thống!";

            //  Kiểm tra số điện thoại (10-11 số)
            if (!string.IsNullOrEmpty(nv.SoDienThoai))
            {
                if (nv.SoDienThoai.Length < 10 || nv.SoDienThoai.Length > 11 || !nv.SoDienThoai.All(char.IsDigit))
                    return "Số điện thoại phải là số và có từ 10-11 chữ số!";

                bool biTrungSDT = context.Nhan_Vien.Any(n => n.SoDienThoai == nv.SoDienThoai && (isThemMoi || n.MaNhanVien != nv.MaNhanVien));
                if (biTrungSDT) return "Số điện thoại này đã được sử dụng!";
            }

            // Kiểm tra độ tuổi (Ví dụ từ 18 - 60)
            int tuoi = DateTime.Now.Year - nv.NgaySinh.Year;
            if (tuoi < 18 || tuoi > 60) return "Tuổi nhân viên phải từ 18 đến 60!";

            return ""; // Không có lỗi
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData(); // Reset lại dữ liệu cũ
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

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
                ImportNhanVien(filePath, lstLog);
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                grBoxDanhSachLog.Visible = true;

                string filePath = saveFileDialog.FileName;
                ExportNhanVien(filePath, lstLog);
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Hiển thị tên phòng
            if (dataGridView.Columns[e.ColumnIndex].Name == "MaPhong" && e.Value != null)
            {
                int id = (int)e.Value;
                var item = context.Phong_Ban.Find(id);
                if (item != null) e.Value = item.TenPhong;
            }
            // Hiển thị tên chức vụ
            if (dataGridView.Columns[e.ColumnIndex].Name == "MaChucVu" && e.Value != null)
            {
                int id = (int)e.Value;
                var item = context.Chuc_Vu.Find(id);
                if (item != null) e.Value = item.TenChucVu;
            }
        }


        public void ImportNhanVien(string filePath, ListBox lstLog)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        int soDongThanhCong = 0;
                        int soDongThatBai = 0;

                        lstLog.Visible = true;
                        lstLog.Items.Clear();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu nhập danh sách nhân viên...");

                        var ws = workbook.Worksheet(1);
                        var rows = ws.RowsUsed().Skip(1);

                        foreach (var row in rows)
                        {
                            try
                            {
                                string hoTen = row.Cell(2).GetValue<string>();
                                if (string.IsNullOrWhiteSpace(hoTen)) continue;

                                // Kiểm tra mã phòng ban
                                int maPB = row.Cell(7).GetValue<int>();
                                if (!context.Phong_Ban.Any(p => p.MaPhong == maPB))
                                {
                                    throw new Exception($"Mã phòng ban {maPB} không tồn tại!");
                                }

                                int maCV = row.Cell(8).GetValue<int>();
                                if (!context.Chuc_Vu.Any(c => c.MaChucVu == maCV))
                                {
                                    throw new Exception($"Mã chức vụ {maCV} không tồn tại!");
                                }

                                var nv = new Nhan_Vien
                                {
                                    HoTen = hoTen,
                                    NgaySinh = row.Cell(3).GetDateTime(),
                                    Email = row.Cell(4).GetValue<string>(),
                                    SoDienThoai = row.Cell(5).GetValue<string>(),
                                    DiaChi = row.Cell(6).GetValue<string>(),
                                    MaPhong = maPB,
                                    MaChucVu = maCV
                                };

                                string loi = KiemTraHopLe(nv, true);
                                if (loi == "")
                                {
                                    context.Nhan_Vien.Add(nv);
                                    context.SaveChanges();

                                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ Nhập NV: {hoTen} - thành công");
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
                                Application.DoEvents();
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

        public void ExportNhanVien(string filePath, ListBox lstLog)
        {
            try
            {
                lstLog.Visible = true;
                lstLog.Items.Clear();
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu xuất danh sách nhân viên...");

                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Nhan Vien");
                    // Header
                    string[] headers = { "Mã NV", "Họ Tên", "Ngày Sinh", "Email", "Số Điện Thoại", "Địa Chỉ", "Mã Phòng Ban", "Mã Chức Vụ" };
                    for (int h = 0; h < headers.Length; h++) ws.Cell(1, h + 1).Value = headers[h];

                    var listNV = context.Nhan_Vien.ToList();
                    for (int i = 0; i < listNV.Count; i++)
                    {
                        int r = i + 2;
                        ws.Cell(r, 1).Value = listNV[i].MaNhanVien;
                        ws.Cell(r, 2).Value = listNV[i].HoTen;
                        ws.Cell(r, 3).Value = listNV[i].NgaySinh;
                        ws.Cell(r, 3).Style.DateFormat.Format = "dd/mm/yyyy";
                        ws.Cell(r, 4).Value = listNV[i].Email;
                        ws.Cell(r, 5).Value = listNV[i].SoDienThoai;
                        ws.Cell(r, 6).Value = listNV[i].DiaChi;
                        ws.Cell(r, 7).Value = listNV[i].MaPhong;
                        ws.Cell(r, 8).Value = listNV[i].MaChucVu;

                        // Log trực tiếp
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang xuất NV: {listNV[i].HoTen} - thành công");
                        lstLog.TopIndex = lstLog.Items.Count - 1;
                        Application.DoEvents();
                    }
                    ws.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);

                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ XUẤT FILE NHÂN VIÊN HOÀN TẤT!");
                    MessageBox.Show("Xuất danh sách nhân viên thành công!");
                }
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ❌ LỖI: {ex.Message}");
            }
        }

    }
}

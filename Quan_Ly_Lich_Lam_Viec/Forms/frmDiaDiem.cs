using ClosedXML.Excel;
using Quan_Ly_Lich_Lam_Viec.Data;

namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    public partial class frmDiaDiem : Form
    {
        public frmDiaDiem()
        {
            InitializeComponent();
        }

        private void frmDiaDiem_Load(object sender, EventArgs e)
        {
            LoadData();
            BatTatChucNang(false);
        }

        Quan_Li_Lich_Lam_DbContext context = new Quan_Li_Lich_Lam_DbContext();
        BindingSource ddBindingSource = new BindingSource();
        bool xuLyThem = false;

        private void LoadData()
        {
            context = new Quan_Li_Lich_Lam_DbContext();
            var listDD = context.Dia_Diem.ToList();

            ddBindingSource.DataSource = context.Dia_Diem.Local.ToBindingList();
            dataGridView.DataSource = ddBindingSource;

            ThietLapBinding();
        }

        private void ThietLapBinding()
        {
            // Xóa binding cũ để tránh lỗi Duplicate
            txtTenDiaDiem.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            numSucChua.DataBindings.Clear();
            txtThietBi.DataBindings.Clear();

            // Thiết lập binding mới
            txtTenDiaDiem.DataBindings.Add("Text", ddBindingSource, "TenDiaDiem", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDiaChi.DataBindings.Add("Text", ddBindingSource, "DiaChiCuThe", true, DataSourceUpdateMode.OnPropertyChanged);
            numSucChua.DataBindings.Add("Value", ddBindingSource, "SucChua", true, DataSourceUpdateMode.OnPropertyChanged);
            txtThietBi.DataBindings.Add("Text", ddBindingSource, "ThietBi", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtTenDiaDiem.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            numSucChua.Enabled = giaTri;
            txtThietBi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);
            ddBindingSource.AddNew();
            txtTenDiaDiem.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDiaDiem.Text))
            {
                MessageBox.Show("Tên địa điểm không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDiaDiem.Focus();
                return;
            }

            if (xuLyThem && context.Dia_Diem.Any(d => d.TenDiaDiem == txtTenDiaDiem.Text.Trim()))
            {
                MessageBox.Show("Địa điểm này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDiaDiem.Focus();
                return;
            }

            try
            {
                var ddHienTai = (Dia_Diem)ddBindingSource.Current;
                int sucChuaMoi = (int)numSucChua.Value;


                if (!xuLyThem)
                {
                    // Kiểm tra xem sức chứa mới có thấp hơn số người đang dùng phòng không
                    if (!KiemTraHopLeKhiSuaSucChua(ddHienTai.MaDiaDiem, sucChuaMoi))
                    {
                        return;
                    }
                }

                ddBindingSource.EndEdit(); // Xác nhận các thay đổi trên BindingSource

                if (xuLyThem)
                {
                    context.Dia_Diem.Add(ddHienTai);
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thông tin địa điểm thành công!", "Thành công");

                LoadData();
                BatTatChucNang(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (ddBindingSource.Current == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ddBindingSource.CancelEdit();
            LoadData();
            BatTatChucNang(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ddBindingSource.Current == null) return;

            var dd = (Dia_Diem)ddBindingSource.Current;

            // Kiểm tra xem địa điểm này có đang được dùng trong lịch nào không
            bool dangDung = context.Lich_Lam_Viec.Any(l => l.MaDiaDiem == dd.MaDiaDiem);
            if (dangDung)
            {
                MessageBox.Show("Không thể xóa địa điểm này vì đã có lịch làm việc được xếp tại đây!", "Cảnh báo");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa địa điểm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                context.Dia_Diem.Remove(dd);
                context.SaveChanges();
                LoadData();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool KiemTraHopLeKhiSuaSucChua(int maDD, int sucChuaMoi)
        {
            // Tìm các lịch sắp tới (hoặc đang diễn ra) tại địa điểm này
            var lichViPham = context.Lich_Lam_Viec
                .Where(l => l.MaDiaDiem == maDD)
                .ToList() // Lấy về để kiểm tra
                .Where(l => l.SoLuongDuKien > sucChuaMoi)
                .OrderByDescending(l => l.SoLuongDuKien)
                .FirstOrDefault();

            if (lichViPham != null)
            {
                string msg = $"KHÔNG THỂ GIẢM SỨC CHỨA!\n\n" +
                             $"Phòng này đang được sử dụng cho lịch: '{lichViPham.TieuDe}'\n" +
                             $"- Số người tham dự của lịch đó: {lichViPham.SoLuongDuKien} người.\n" +
                             $"- Sức chứa bạn định sửa ({sucChuaMoi}) nhỏ hơn số người dùng.\n\n" +
                             $"Vui lòng điều chỉnh lại sức chứa hoặc sửa số người trong lịch trước.";

                MessageBox.Show(msg, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ImportDiaDiem(string filePath, ListBox lstLog)
        {
            using (var workbook = new XLWorkbook(filePath))
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        lstLog.Items.Clear();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu nhập dữ liệu Địa điểm...");
                        Application.DoEvents();

                        int soDongThanhCong = 0;
                        int soDongThatBai = 0;

                        var worksheet = workbook.Worksheet(1);
                        var rows = worksheet.RowsUsed().Skip(1);

                        foreach (var row in rows)
                        {
                            string tenDD = row.Cell(2).GetValue<string>();
                            int sucChua = row.Cell(5).GetValue<int>();

                            try
                            {

                                if (context.Dia_Diem.Any(d => d.TenDiaDiem == tenDD.Trim()))
                                {
                                    throw new Exception("Địa điểm này đã tồn tại");
                                }

                                if (!KiemTraHopLeKhiSuaSucChua(0, sucChua))
                                {
                                    throw new Exception("Sức chứa không đủ cho các lịch dự kiến");
                                }

                                var dd = new Dia_Diem
                                {
                                    TenDiaDiem = tenDD.Trim(),
                                    DiaChiCuThe = row.Cell(3).GetValue<string>(),
                                    ThietBi = row.Cell(4).GetValue<string>(),
                                    SucChua = sucChua
                                };

                                context.Dia_Diem.Add(dd);
                                context.SaveChanges();

                                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Địa điểm: {tenDD} - thành công");
                                soDongThanhCong++;
                            }
                            catch (Exception ex)
                            {
                                // Không hiện MessageBox ở đây để tránh treo quá trình Import
                                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ❌ Dòng {row.RowNumber()}: {tenDD} - Thất bại ({ex.Message})");
                                soDongThatBai++;
                            }
                            lstLog.TopIndex = lstLog.Items.Count - 1;
                            Application.DoEvents();
                        }

                        transaction.Commit();
                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ Hoàn tất quá trình nhập!");

                        // Hiển thị thông báo tổng kết như bạn yêu cầu
                        if (soDongThatBai == 0)
                        {
                            MessageBox.Show($"Nhập hoàn tất thành công {soDongThanhCong} dòng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Quá trình nhập không thành công hoàn toàn!\n- Thành công: {soDongThanhCong}\n- Thất bại: {soDongThatBai}", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi hệ thống nghiêm trọng: " + ex.Message);
                    }
                }
            }
        }

        public void ExportDiaDiem(string filePath, ListBox lstLog)
        {
            try
            {
                lstLog.Items.Clear();
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang khởi tạo file Excel địa điểm...");

                using (var workbook = new XLWorkbook())
                {
                    var ws = workbook.Worksheets.Add("Danh Sách Địa Điểm");


                    string[] headers = { "Mã Địa Điểm", "Tên Địa Điểm", "Địa Chỉ", "Trang Thiết Bị", "Sức Chứa" };
                    for (int h = 0; h < headers.Length; h++) ws.Cell(1, h + 1).Value = headers[h];

                    var listDD = context.Dia_Diem.ToList();
                    for (int i = 0; i < listDD.Count; i++)
                    {
                        int r = i + 2;
                        ws.Cell(r, 1).Value = listDD[i].MaDiaDiem;
                        ws.Cell(r, 2).Value = listDD[i].TenDiaDiem;
                        ws.Cell(r, 3).Value = listDD[i].DiaChiCuThe;
                        ws.Cell(r, 4).Value = listDD[i].ThietBi;
                        ws.Cell(r, 5).Value = listDD[i].SucChua;

                        lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] Đang xuất: {listDD[i].TenDiaDiem} - thành công");
                        lstLog.TopIndex = lstLog.Items.Count - 1;
                        Application.DoEvents();
                    }

                    ws.Columns().AdjustToContents();
                    workbook.SaveAs(filePath);

                    lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ✅ XUẤT FILE HOÀN TẤT!");
                    MessageBox.Show("Dữ liệu địa điểm đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"[{DateTime.Now:HH:mm:ss}] ❌ LỖI: {ex.Message}");
                MessageBox.Show("Có lỗi xảy ra khi xuất file: " + ex.Message);
            }
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
                ImportDiaDiem(filePath, lstLog);
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DiaDiem_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                grBoxDanhSachLog.Visible = true;

                string filePath = saveFileDialog.FileName;
                ExportDiaDiem(filePath, lstLog);
            }
        }
    }
}

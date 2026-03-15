namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmLichLamViec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            rtbNoiDung = new RichTextBox();
            numSoLuongDuKien = new NumericUpDown();
            dtpKetThuc = new DateTimePicker();
            dtpBatDau = new DateTimePicker();
            cboDiaDiem = new ComboBox();
            cboLoaiCongViec = new ComboBox();
            txtTieuDe = new TextBox();
            lblThongTinPhong = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnXuat = new Button();
            btnNhap = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnTimKiem = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaLich = new DataGridViewTextBoxColumn();
            TieuDe = new DataGridViewTextBoxColumn();
            NoiDung = new DataGridViewTextBoxColumn();
            BatDau = new DataGridViewTextBoxColumn();
            KetThuc = new DataGridViewTextBoxColumn();
            SoLuongDuKien = new DataGridViewTextBoxColumn();
            MaLoaiCV = new DataGridViewTextBoxColumn();
            MaDiaDiem = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewLinkColumn();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongDuKien).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grBoxDanhSachLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(numSoLuongDuKien);
            groupBox1.Controls.Add(dtpKetThuc);
            groupBox1.Controls.Add(dtpBatDau);
            groupBox1.Controls.Add(cboDiaDiem);
            groupBox1.Controls.Add(cboLoaiCongViec);
            groupBox1.Controls.Add(txtTieuDe);
            groupBox1.Controls.Add(lblThongTinPhong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1062, 350);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lịch làm việc";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rtbNoiDung);
            groupBox3.Location = new Point(67, 65);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(623, 84);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nội dung";
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Dock = DockStyle.Fill;
            rtbNoiDung.Location = new Point(3, 23);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.Size = new Size(617, 58);
            rtbNoiDung.TabIndex = 4;
            rtbNoiDung.Text = "";
            // 
            // numSoLuongDuKien
            // 
            numSoLuongDuKien.Location = new Point(545, 219);
            numSoLuongDuKien.Name = "numSoLuongDuKien";
            numSoLuongDuKien.Size = new Size(142, 27);
            numSoLuongDuKien.TabIndex = 6;
            // 
            // dtpKetThuc
            // 
            dtpKetThuc.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpKetThuc.Format = DateTimePickerFormat.Custom;
            dtpKetThuc.Location = new Point(545, 175);
            dtpKetThuc.Name = "dtpKetThuc";
            dtpKetThuc.Size = new Size(142, 27);
            dtpKetThuc.TabIndex = 5;
            dtpKetThuc.ValueChanged += dtpKetThuc_ValueChanged;
            // 
            // dtpBatDau
            // 
            dtpBatDau.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpBatDau.Format = DateTimePickerFormat.Custom;
            dtpBatDau.Location = new Point(202, 175);
            dtpBatDau.Name = "dtpBatDau";
            dtpBatDau.Size = new Size(163, 27);
            dtpBatDau.TabIndex = 5;
            dtpBatDau.ValueChanged += dtpBatDau_ValueChanged;
            // 
            // cboDiaDiem
            // 
            cboDiaDiem.FormattingEnabled = true;
            cboDiaDiem.Location = new Point(202, 265);
            cboDiaDiem.Name = "cboDiaDiem";
            cboDiaDiem.Size = new Size(485, 28);
            cboDiaDiem.TabIndex = 3;
            cboDiaDiem.SelectedIndexChanged += cboDiaDiem_SelectedIndexChanged;
            // 
            // cboLoaiCongViec
            // 
            cboLoaiCongViec.FormattingEnabled = true;
            cboLoaiCongViec.Location = new Point(202, 218);
            cboLoaiCongViec.Name = "cboLoaiCongViec";
            cboLoaiCongViec.Size = new Size(163, 28);
            cboLoaiCongViec.TabIndex = 3;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new Point(152, 32);
            txtTieuDe.Multiline = true;
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(538, 27);
            txtTieuDe.TabIndex = 1;
            // 
            // lblThongTinPhong
            // 
            lblThongTinPhong.AutoSize = true;
            lblThongTinPhong.Location = new Point(68, 308);
            lblThongTinPhong.Name = "lblThongTinPhong";
            lblThongTinPhong.Size = new Size(228, 20);
            lblThongTinPhong.TabIndex = 0;
            lblThongTinPhong.Text = "Thông tin địa chỉ đang cập nhật...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 221);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 0;
            label4.Text = "Số lượng tham gia:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 175);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 0;
            label6.Text = "Thời gian kết thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 221);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 0;
            label5.Text = "Loại công việc:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 273);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 0;
            label7.Text = "Địa điểm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 175);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 0;
            label3.Text = "Thời gian bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Tiêu đề (*):";
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Segoe UI", 10.2F);
            btnXuat.Location = new Point(741, 265);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(219, 35);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Segoe UI", 10.2F);
            btnNhap.Location = new Point(741, 224);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(219, 35);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(854, 119);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 35);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 10.2F);
            btnHuyBo.Location = new Point(854, 79);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 35);
            btnHuyBo.TabIndex = 0;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10.2F);
            btnTimKiem.Location = new Point(741, 178);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(219, 35);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(741, 119);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 35);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.ForeColor = Color.FromArgb(0, 192, 0);
            btnLuu.Location = new Point(854, 39);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 35);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Location = new Point(741, 79);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 35);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Location = new Point(741, 39);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 35);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 350);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1062, 341);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách lịch làm việc";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaLich, TieuDe, NoiDung, BatDau, KetThuc, SoLuongDuKien, MaLoaiCV, MaDiaDiem, TinhTrang });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1056, 315);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaLich
            // 
            MaLich.DataPropertyName = "MaLich";
            MaLich.HeaderText = "Mã lịch";
            MaLich.MinimumWidth = 6;
            MaLich.Name = "MaLich";
            MaLich.ReadOnly = true;
            // 
            // TieuDe
            // 
            TieuDe.DataPropertyName = "TieuDe";
            TieuDe.HeaderText = "Tiêu đề";
            TieuDe.MinimumWidth = 6;
            TieuDe.Name = "TieuDe";
            TieuDe.ReadOnly = true;
            // 
            // NoiDung
            // 
            NoiDung.DataPropertyName = "NoiDung";
            NoiDung.HeaderText = "Nội dung";
            NoiDung.MinimumWidth = 6;
            NoiDung.Name = "NoiDung";
            NoiDung.ReadOnly = true;
            // 
            // BatDau
            // 
            BatDau.DataPropertyName = "ThoiGianBatDau";
            BatDau.HeaderText = "Thời gian bắt đầu";
            BatDau.MinimumWidth = 6;
            BatDau.Name = "BatDau";
            BatDau.ReadOnly = true;
            // 
            // KetThuc
            // 
            KetThuc.DataPropertyName = "ThoiGianKetThuc";
            KetThuc.HeaderText = "Thời gian kết thúc";
            KetThuc.MinimumWidth = 6;
            KetThuc.Name = "KetThuc";
            KetThuc.ReadOnly = true;
            // 
            // SoLuongDuKien
            // 
            SoLuongDuKien.DataPropertyName = "SoLuongDuKien";
            SoLuongDuKien.HeaderText = "Số lượng tham gia";
            SoLuongDuKien.MinimumWidth = 6;
            SoLuongDuKien.Name = "SoLuongDuKien";
            SoLuongDuKien.ReadOnly = true;
            // 
            // MaLoaiCV
            // 
            MaLoaiCV.DataPropertyName = "MaLoaiCV";
            MaLoaiCV.HeaderText = "Chức vụ";
            MaLoaiCV.MinimumWidth = 6;
            MaLoaiCV.Name = "MaLoaiCV";
            MaLoaiCV.ReadOnly = true;
            // 
            // MaDiaDiem
            // 
            MaDiaDiem.DataPropertyName = "MaDiaDiem";
            MaDiaDiem.HeaderText = "Địa điểm";
            MaDiaDiem.MinimumWidth = 6;
            MaDiaDiem.Name = "MaDiaDiem";
            MaDiaDiem.ReadOnly = true;
            // 
            // TinhTrang
            // 
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.ReadOnly = true;
            TinhTrang.Resizable = DataGridViewTriState.True;
            TinhTrang.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Location = new Point(0, 554);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(1062, 137);
            grBoxDanhSachLog.TabIndex = 3;
            grBoxDanhSachLog.TabStop = false;
            grBoxDanhSachLog.Text = "Danh sách log";
            grBoxDanhSachLog.Visible = false;
            // 
            // lstLog
            // 
            lstLog.Dock = DockStyle.Fill;
            lstLog.FormattingEnabled = true;
            lstLog.Location = new Point(3, 23);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(1056, 111);
            lstLog.TabIndex = 0;
            // 
            // frmLichLamViec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 691);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLichLamViec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch làm việc";
            Load += frmLichLamViec_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSoLuongDuKien).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboLoaiCongViec;
        private TextBox txtTieuDe;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label3;
        private Label label1;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private RichTextBox rtbNoiDung;
        private DateTimePicker dtpBatDau;
        private DateTimePicker dtpKetThuc;
        private ComboBox cboDiaDiem;
        private NumericUpDown numSoLuongDuKien;
        private Label label4;
        private Label lblThongTinPhong;
        private GroupBox groupBox3;
        private Button btnXuat;
        private DataGridViewTextBoxColumn MaLich;
        private DataGridViewTextBoxColumn TieuDe;
        private DataGridViewTextBoxColumn NoiDung;
        private DataGridViewTextBoxColumn BatDau;
        private DataGridViewTextBoxColumn KetThuc;
        private DataGridViewTextBoxColumn SoLuongDuKien;
        private DataGridViewTextBoxColumn MaLoaiCV;
        private DataGridViewTextBoxColumn MaDiaDiem;
        private DataGridViewLinkColumn TinhTrang;
        private ListBox lstLog;
        private GroupBox grBoxDanhSachLog;
    }
}
namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmNhanVien
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
            cboMaChucVu = new ComboBox();
            cboMaPhong = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtHoVaTen = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
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
            MaNhanVien = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            MaPhong = new DataGridViewTextBoxColumn();
            MaChucVu = new DataGridViewTextBoxColumn();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            grBoxDanhSachLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaChucVu);
            groupBox1.Controls.Add(cboMaPhong);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
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
            groupBox1.Size = new Size(1101, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // cboMaChucVu
            // 
            cboMaChucVu.FormattingEnabled = true;
            cboMaChucVu.Location = new Point(494, 104);
            cboMaChucVu.Name = "cboMaChucVu";
            cboMaChucVu.Size = new Size(153, 27);
            cboMaChucVu.TabIndex = 3;
            // 
            // cboMaPhong
            // 
            cboMaPhong.FormattingEnabled = true;
            cboMaPhong.Location = new Point(494, 67);
            cboMaPhong.Name = "cboMaPhong";
            cboMaPhong.Size = new Size(153, 27);
            cboMaPhong.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(141, 66);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(212, 27);
            dtpNgaySinh.TabIndex = 2;
            dtpNgaySinh.Value = new DateTime(2026, 1, 30, 12, 55, 19, 0);
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(141, 146);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(506, 27);
            txtDiaChi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(212, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(494, 34);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(153, 27);
            txtSDT.TabIndex = 1;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(141, 33);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(212, 27);
            txtHoVaTen.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 112);
            label6.Name = "label6";
            label6.Size = new Size(92, 19);
            label6.TabIndex = 0;
            label6.Text = "Mã chức vụ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 72);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 0;
            label5.Text = "Mã phòng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 149);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 0;
            label7.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 112);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(384, 34);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 0;
            label4.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 0;
            label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(103, 19);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Segoe UI", 10.2F);
            btnXuat.Location = new Point(949, 124);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(120, 35);
            btnXuat.TabIndex = 0;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Segoe UI", 10.2F);
            btnNhap.Location = new Point(949, 84);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(120, 35);
            btnNhap.TabIndex = 0;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(822, 124);
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
            btnHuyBo.Location = new Point(822, 84);
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
            btnTimKiem.Location = new Point(949, 44);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(120, 35);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(709, 124);
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
            btnLuu.Location = new Point(822, 44);
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
            btnSua.Location = new Point(709, 84);
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
            btnThem.Location = new Point(709, 44);
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
            groupBox2.Location = new Point(0, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1101, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaNhanVien, HoTen, NgaySinh, Email, SoDienThoai, DiaChi, MaPhong, MaChucVu });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1095, 279);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Mã nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            // 
            // HoTen
            // 
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // MaPhong
            // 
            MaPhong.DataPropertyName = "MaPhong";
            MaPhong.HeaderText = "Phòng ban";
            MaPhong.MinimumWidth = 6;
            MaPhong.Name = "MaPhong";
            // 
            // MaChucVu
            // 
            MaChucVu.DataPropertyName = "MaChucVu";
            MaChucVu.HeaderText = "Chức vụ";
            MaChucVu.MinimumWidth = 6;
            MaChucVu.Name = "MaChucVu";
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Location = new Point(0, 372);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(1101, 125);
            grBoxDanhSachLog.TabIndex = 2;
            grBoxDanhSachLog.TabStop = false;
            grBoxDanhSachLog.Text = "Danh sách log";
            grBoxDanhSachLog.Visible = false;
            // 
            // lstLog
            // 
            lstLog.Dock = DockStyle.Fill;
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 19;
            lstLog.Location = new Point(3, 23);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(1095, 99);
            lstLog.TabIndex = 0;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 497);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnThem;
        private GroupBox groupBox2;
        private Button btnXuat;
        private Button btnNhap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnTimKiem;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtHoVaTen;
        private Label label7;
        private ComboBox cboMaChucVu;
        private ComboBox cboMaPhong;
        private TextBox txtSDT;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn MaPhong;
        private DataGridViewTextBoxColumn MaChucVu;
        private GroupBox grBoxDanhSachLog;
        private ListBox lstLog;
    }
}
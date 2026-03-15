namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmPhanCong
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
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chkXacNhan = new CheckBox();
            cboNhanVien = new ComboBox();
            cboVaiTro = new ComboBox();
            cboLichLamViec = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaPhanCong = new DataGridViewTextBoxColumn();
            MaLich = new DataGridViewTextBoxColumn();
            MaNhanVien = new DataGridViewTextBoxColumn();
            Vai_Tro = new DataGridViewTextBoxColumn();
            Da_Xac_Nhan = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chkXacNhan);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(cboVaiTro);
            groupBox1.Controls.Add(cboLichLamViec);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1073, 136);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin phân công";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(920, 76);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 35);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 10.2F);
            btnHuyBo.Location = new Point(920, 31);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 35);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(655, 76);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 35);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.ForeColor = Color.FromArgb(0, 192, 0);
            btnLuu.Location = new Point(788, 76);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 35);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Location = new Point(788, 32);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 35);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Location = new Point(655, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 35);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 33);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 3;
            label3.Text = "Vai trò (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 3;
            label1.Text = "Chọn lịch (*):";
            // 
            // chkXacNhan
            // 
            chkXacNhan.AutoSize = true;
            chkXacNhan.Location = new Point(432, 82);
            chkXacNhan.Name = "chkXacNhan";
            chkXacNhan.Size = new Size(112, 24);
            chkXacNhan.TabIndex = 2;
            chkXacNhan.Text = "Đã xác nhận";
            chkXacNhan.UseVisualStyleBackColor = true;
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(142, 74);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 0;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Items.AddRange(new object[] { "Chủ trì", "Thư ký", "Thành viên", "Hỗ trợ" });
            cboVaiTro.Location = new Point(432, 32);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(151, 28);
            cboVaiTro.TabIndex = 0;
            cboVaiTro.SelectedIndexChanged += cboVaiTro_SelectedIndexChanged;
            // 
            // cboLichLamViec
            // 
            cboLichLamViec.FormattingEnabled = true;
            cboLichLamViec.Location = new Point(142, 30);
            cboLichLamViec.Name = "cboLichLamViec";
            cboLichLamViec.Size = new Size(151, 28);
            cboLichLamViec.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 136);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1073, 165);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân sự tham gia";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaPhanCong, MaLich, MaNhanVien, Vai_Tro, Da_Xac_Nhan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1067, 139);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // MaPhanCong
            // 
            MaPhanCong.DataPropertyName = "MaPhanCong";
            MaPhanCong.HeaderText = "Mã phân công";
            MaPhanCong.MinimumWidth = 6;
            MaPhanCong.Name = "MaPhanCong";
            MaPhanCong.ReadOnly = true;
            // 
            // MaLich
            // 
            MaLich.DataPropertyName = "MaLich";
            MaLich.HeaderText = "Loại lịch";
            MaLich.MinimumWidth = 6;
            MaLich.Name = "MaLich";
            MaLich.ReadOnly = true;
            // 
            // MaNhanVien
            // 
            MaNhanVien.DataPropertyName = "MaNhanVien";
            MaNhanVien.HeaderText = "Nhân viên";
            MaNhanVien.MinimumWidth = 6;
            MaNhanVien.Name = "MaNhanVien";
            MaNhanVien.ReadOnly = true;
            // 
            // Vai_Tro
            // 
            Vai_Tro.DataPropertyName = "Vai_Tro";
            Vai_Tro.HeaderText = "Vai trò";
            Vai_Tro.MinimumWidth = 6;
            Vai_Tro.Name = "Vai_Tro";
            Vai_Tro.ReadOnly = true;
            // 
            // Da_Xac_Nhan
            // 
            Da_Xac_Nhan.DataPropertyName = "Da_Xac_Nhan";
            Da_Xac_Nhan.HeaderText = "Xác nhận";
            Da_Xac_Nhan.MinimumWidth = 6;
            Da_Xac_Nhan.Name = "Da_Xac_Nhan";
            Da_Xac_Nhan.ReadOnly = true;
            // 
            // frmPhanCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 301);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmPhanCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phân công";
            Load += frmPhanCong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cboNhanVien;
        private ComboBox cboLichLamViec;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkXacNhan;
        private ComboBox cboVaiTro;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaPhanCong;
        private DataGridViewTextBoxColumn MaLich;
        private DataGridViewTextBoxColumn MaNhanVien;
        private DataGridViewTextBoxColumn Vai_Tro;
        private DataGridViewTextBoxColumn Da_Xac_Nhan;
    }
}
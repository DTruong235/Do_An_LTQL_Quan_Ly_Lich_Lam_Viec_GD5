namespace Quan_Ly_Lich_Lam_Viec.Forms
{
    partial class frmDiaDiem
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
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            MaDiaDiem = new DataGridViewTextBoxColumn();
            TenDiaDiem = new DataGridViewTextBoxColumn();
            DiaChiCuThe = new DataGridViewTextBoxColumn();
            ThietBi = new DataGridViewTextBoxColumn();
            SucChua = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTenDiaDiem = new TextBox();
            txtDiaChi = new TextBox();
            numSucChua = new NumericUpDown();
            btnThem = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnTimKiem = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            txtThietBi = new TextBox();
            groupBox1 = new GroupBox();
            grBoxDanhSachLog = new GroupBox();
            lstLog = new ListBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSucChua).BeginInit();
            groupBox1.SuspendLayout();
            grBoxDanhSachLog.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 281);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(677, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách địa điểm";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { MaDiaDiem, TenDiaDiem, DiaChiCuThe, ThietBi, SucChua });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 23);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(671, 176);
            dataGridView.TabIndex = 0;
            // 
            // MaDiaDiem
            // 
            MaDiaDiem.DataPropertyName = "MaDiaDiem";
            MaDiaDiem.HeaderText = "Mã địa điểm";
            MaDiaDiem.MinimumWidth = 6;
            MaDiaDiem.Name = "MaDiaDiem";
            MaDiaDiem.ReadOnly = true;
            MaDiaDiem.Visible = false;
            // 
            // TenDiaDiem
            // 
            TenDiaDiem.DataPropertyName = "TenDiaDiem";
            TenDiaDiem.HeaderText = "Tên địa điểm";
            TenDiaDiem.MinimumWidth = 6;
            TenDiaDiem.Name = "TenDiaDiem";
            TenDiaDiem.ReadOnly = true;
            // 
            // DiaChiCuThe
            // 
            DiaChiCuThe.DataPropertyName = "DiaChiCuThe";
            DiaChiCuThe.HeaderText = "Địa điểm";
            DiaChiCuThe.MinimumWidth = 6;
            DiaChiCuThe.Name = "DiaChiCuThe";
            DiaChiCuThe.ReadOnly = true;
            // 
            // ThietBi
            // 
            ThietBi.DataPropertyName = "ThietBi";
            ThietBi.HeaderText = "Thiết bị";
            ThietBi.MinimumWidth = 6;
            ThietBi.Name = "ThietBi";
            ThietBi.ReadOnly = true;
            // 
            // SucChua
            // 
            SucChua.DataPropertyName = "SucChua";
            SucChua.HeaderText = "Sức chứa";
            SucChua.MinimumWidth = 6;
            SucChua.Name = "SucChua";
            SucChua.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên địa điểm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 83);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "Sức chứa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 173);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 0;
            label4.Text = "Thiết bị:";
            // 
            // txtTenDiaDiem
            // 
            txtTenDiaDiem.Location = new Point(125, 34);
            txtTenDiaDiem.Name = "txtTenDiaDiem";
            txtTenDiaDiem.Size = new Size(252, 27);
            txtTenDiaDiem.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(125, 76);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(252, 27);
            txtDiaChi.TabIndex = 1;
            // 
            // numSucChua
            // 
            numSucChua.Location = new Point(125, 121);
            numSucChua.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSucChua.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numSucChua.Name = "numSucChua";
            numSucChua.Size = new Size(252, 27);
            numSucChua.TabIndex = 2;
            numSucChua.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10.2F);
            btnThem.Location = new Point(409, 31);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(106, 35);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10.2F);
            btnSua.Location = new Point(409, 71);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(106, 35);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 10.2F);
            btnLuu.ForeColor = Color.FromArgb(0, 192, 0);
            btnLuu.Location = new Point(522, 31);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(106, 35);
            btnLuu.TabIndex = 10;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10.2F);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(409, 111);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(106, 35);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 10.2F);
            btnTimKiem.Location = new Point(409, 168);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(219, 35);
            btnTimKiem.TabIndex = 8;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Font = new Font("Segoe UI", 10.2F);
            btnHuyBo.Location = new Point(522, 71);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(106, 35);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F);
            btnThoat.Location = new Point(522, 111);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(106, 35);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Segoe UI", 10.2F);
            btnNhap.Location = new Point(409, 226);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(107, 35);
            btnNhap.TabIndex = 5;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Font = new Font("Segoe UI", 10.2F);
            btnXuat.Location = new Point(522, 226);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(106, 35);
            btnXuat.TabIndex = 4;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // txtThietBi
            // 
            txtThietBi.Location = new Point(125, 173);
            txtThietBi.Multiline = true;
            txtThietBi.Name = "txtThietBi";
            txtThietBi.Size = new Size(252, 88);
            txtThietBi.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtThietBi);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(numSucChua);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenDiaDiem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(677, 281);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin địa điểm";
            // 
            // grBoxDanhSachLog
            // 
            grBoxDanhSachLog.Controls.Add(lstLog);
            grBoxDanhSachLog.Dock = DockStyle.Bottom;
            grBoxDanhSachLog.Location = new Point(0, 358);
            grBoxDanhSachLog.Name = "grBoxDanhSachLog";
            grBoxDanhSachLog.Size = new Size(677, 125);
            grBoxDanhSachLog.TabIndex = 2;
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
            lstLog.Size = new Size(671, 99);
            lstLog.TabIndex = 0;
            // 
            // frmDiaDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 483);
            Controls.Add(grBoxDanhSachLog);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmDiaDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Địa điểm";
            Load += frmDiaDiem_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSucChua).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grBoxDanhSachLog.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn MaDiaDiem;
        private DataGridViewTextBoxColumn TenDiaDiem;
        private DataGridViewTextBoxColumn DiaChiCuThe;
        private DataGridViewTextBoxColumn ThietBi;
        private DataGridViewTextBoxColumn SucChua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTenDiaDiem;
        private TextBox txtDiaChi;
        private NumericUpDown numSucChua;
        private Button btnThem;
        private Button btnSua;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnTimKiem;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtThietBi;
        private GroupBox groupBox1;
        private GroupBox grBoxDanhSachLog;
        private ListBox lstLog;
    }
}
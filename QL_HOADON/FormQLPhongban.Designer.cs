namespace QL_HOANDON
{
    partial class FormQLPhongban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLPhongban));
            panel1 = new Panel();
            txtTenphong = new TextBox();
            txtSdt = new TextBox();
            txtMaphong = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvThongtinphongban = new DataGridView();
            c = new Panel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongtinphongban).BeginInit();
            c.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SpringGreen;
            panel1.Controls.Add(txtTenphong);
            panel1.Controls.Add(txtSdt);
            panel1.Controls.Add(txtMaphong);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(27, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 149);
            panel1.TabIndex = 0;
            // 
            // txtTenphong
            // 
            txtTenphong.Location = new Point(576, 16);
            txtTenphong.Name = "txtTenphong";
            txtTenphong.Size = new Size(245, 27);
            txtTenphong.TabIndex = 5;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(201, 90);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(176, 27);
            txtSdt.TabIndex = 4;
            // 
            // txtMaphong
            // 
            txtMaphong.Location = new Point(201, 19);
            txtMaphong.Name = "txtMaphong";
            txtMaphong.Size = new Size(176, 27);
            txtMaphong.TabIndex = 3;
            // txtMaphong.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(431, 15);
            label4.Name = "label4";
            label4.Size = new Size(111, 28);
            label4.TabIndex = 2;
            label4.Text = "Tên phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 89);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 1;
            label3.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 15);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(549, 60);
            label1.TabIndex = 1;
            label1.Text = "THÔNG TIN PHÒNG BAN";
            // 
            // dgvThongtinphongban
            // 
            dgvThongtinphongban.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongtinphongban.Location = new Point(27, 251);
            dgvThongtinphongban.Name = "dgvThongtinphongban";
            dgvThongtinphongban.RowHeadersWidth = 51;
            dgvThongtinphongban.RowTemplate.Height = 29;
            dgvThongtinphongban.Size = new Size(889, 188);
            dgvThongtinphongban.TabIndex = 2;
            dgvThongtinphongban.CellClick += dgvThongtinphongban_CellClick;
            dgvThongtinphongban.SelectionChanged += dgvThongtinphongban_SelectionChanged;
            // 
            // c
            // 
            c.BackColor = Color.Pink;
            c.Controls.Add(btnThoat);
            c.Controls.Add(btnXoa);
            c.Controls.Add(btnLuu);
            c.Controls.Add(btnSua);
            c.Controls.Add(btnThem);
            c.Location = new Point(27, 461);
            c.Name = "c";
            c.Size = new Size(889, 85);
            c.TabIndex = 3;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(706, 20);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 48);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(547, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 48);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(371, 20);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 48);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(201, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(138, 48);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(39, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 48);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            // 
            // FormQLPhongban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 558);
            Controls.Add(c);
            Controls.Add(dgvThongtinphongban);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FormQLPhongban";
            Text = "QUẢN LÍ PHÒNG BAN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongtinphongban).EndInit();
            c.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTenphong;
        private TextBox txtSdt;
        private TextBox txtMaphong;
        private DataGridView dgvThongtinphongban;
        private Panel c;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
    }
}
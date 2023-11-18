namespace QL_HOADON
{
    partial class FormTKNhanVienPhong
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtdienthoai = new TextBox();
            txttenphong = new TextBox();
            cbbmaphong = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dgvtknhanvienphong = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtsonhanvien = new TextBox();
            txttongtienluong = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtknhanvienphong).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Violet;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(62, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 85);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 14);
            label1.Name = "label1";
            label1.Size = new Size(625, 46);
            label1.TabIndex = 0;
            label1.Text = "THỐNG KÊ NHÂN VIÊN THEO PHÒNG";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(txtdienthoai);
            panel2.Controls.Add(txttenphong);
            panel2.Controls.Add(cbbmaphong);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(62, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 105);
            panel2.TabIndex = 1;
            // 
            // txtdienthoai
            // 
            txtdienthoai.Location = new Point(691, 50);
            txtdienthoai.Name = "txtdienthoai";
            txtdienthoai.Size = new Size(146, 27);
            txtdienthoai.TabIndex = 6;
            // 
            // txttenphong
            // 
            txttenphong.Location = new Point(367, 51);
            txttenphong.Name = "txttenphong";
            txttenphong.Size = new Size(219, 27);
            txttenphong.TabIndex = 5;
            // 
            // cbbmaphong
            // 
            cbbmaphong.FormattingEnabled = true;
            cbbmaphong.Location = new Point(110, 50);
            cbbmaphong.Name = "cbbmaphong";
            cbbmaphong.Size = new Size(151, 28);
            cbbmaphong.TabIndex = 4;
            cbbmaphong.SelectedIndexChanged += cbbmaphong_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(592, 52);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 3;
            label7.Text = "Điện thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(267, 55);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 2;
            label6.Text = "Tên phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(15, 52);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 1;
            label5.Text = "Mã phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(251, 28);
            label4.TabIndex = 0;
            label4.Text = "THÔNG TIN PHÒNG BAN";
            // 
            // dgvtknhanvienphong
            // 
            dgvtknhanvienphong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtknhanvienphong.Location = new Point(62, 227);
            dgvtknhanvienphong.Name = "dgvtknhanvienphong";
            dgvtknhanvienphong.RowHeadersWidth = 51;
            dgvtknhanvienphong.RowTemplate.Height = 29;
            dgvtknhanvienphong.Size = new Size(902, 135);
            dgvtknhanvienphong.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 388);
            label2.Name = "label2";
            label2.Size = new Size(178, 31);
            label2.TabIndex = 3;
            label2.Text = "SÔ NHÂN VIÊN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(545, 397);
            label3.Name = "label3";
            label3.Size = new Size(222, 31);
            label3.TabIndex = 4;
            label3.Text = "TỔNG TIỀN LƯƠNG";
            // 
            // txtsonhanvien
            // 
            txtsonhanvien.Location = new Point(304, 398);
            txtsonhanvien.Name = "txtsonhanvien";
            txtsonhanvien.Size = new Size(217, 27);
            txtsonhanvien.TabIndex = 5;
            // 
            // txttongtienluong
            // 
            txttongtienluong.Location = new Point(773, 398);
            txttongtienluong.Name = "txttongtienluong";
            txttongtienluong.Size = new Size(191, 27);
            txttongtienluong.TabIndex = 6;
            // 
            // FormTKNhanVienPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 450);
            Controls.Add(txttongtienluong);
            Controls.Add(txtsonhanvien);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvtknhanvienphong);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormTKNhanVienPhong";
            Text = "FormTKNhanvien";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtknhanvienphong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox txtdienthoai;
        private TextBox txttenphong;
        private ComboBox cbbmaphong;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dgvtknhanvienphong;
        private Label label2;
        private Label label3;
        private TextBox txtsonhanvien;
        private TextBox txttongtienluong;
    }
}
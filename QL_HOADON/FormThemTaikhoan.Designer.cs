namespace QL_HOADON
{
    partial class FormThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemTaiKhoan));
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txtID_User = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            txtQuyen = new Label();
            textBox4 = new TextBox();
            txtTenTK = new Label();
            panel2 = new Panel();
            btnLuu = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(76, 36);
            label7.Name = "label7";
            label7.Size = new Size(487, 38);
            label7.TabIndex = 30;
            label7.Text = "NHẬP THÔNG TIN TÀI KHOẢN MỚI";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtQuyen);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(txtTenTK);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtID_User);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 159);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "ID_User";
            // 
            // txtID_User
            // 
            txtID_User.Location = new Point(146, 25);
            txtID_User.Name = "txtID_User";
            txtID_User.Size = new Size(125, 27);
            txtID_User.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(146, 104);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 111);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(472, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // txtQuyen
            // 
            txtQuyen.AutoSize = true;
            txtQuyen.Location = new Point(363, 111);
            txtQuyen.Name = "txtQuyen";
            txtQuyen.Size = new Size(51, 20);
            txtQuyen.TabIndex = 6;
            txtQuyen.Text = "Quyền";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(472, 25);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // txtTenTK
            // 
            txtTenTK.AutoSize = true;
            txtTenTK.Location = new Point(363, 32);
            txtTenTK.Name = "txtTenTK";
            txtTenTK.Size = new Size(97, 20);
            txtTenTK.TabIndex = 4;
            txtTenTK.Text = "Tên tài khoản";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 255);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnLuu);
            panel2.Location = new Point(649, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 159);
            panel2.TabIndex = 32;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(52, 12);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 48);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(52, 93);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 48);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FormThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label7);
            Name = "FormThemTaiKhoan";
            Text = "THÊM TÀI KHOẢN MỚI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private TextBox textBox3;
        private Label txtQuyen;
        private TextBox textBox4;
        private Label txtTenTK;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtID_User;
        private Label label1;
        private Panel panel2;
        private Button btnLuu;
        private Button btnThoat;
    }
}
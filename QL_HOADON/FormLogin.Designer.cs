namespace QL_HOANDON
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            txtPass = new TextBox();
            label2 = new Label();
            txtTendangnhap = new TextBox();
            label1 = new Label();
            label7 = new Label();
            btnDangnhap = new Button();
            btnThoat = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtTendangnhap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(345, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 298);
            panel1.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(171, 166);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(224, 27);
            txtPass.TabIndex = 35;
            txtPass.PasswordChar = '*';
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 162);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 34;
            label2.Text = "Mật khẩu";
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Location = new Point(171, 96);
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(224, 27);
            txtTendangnhap.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 92);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 32;
            label1.Text = "Tên đăng nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 24);
            label7.Name = "label7";
            label7.Size = new Size(351, 38);
            label7.TabIndex = 31;
            label7.Text = "THÔNG TIN ĐĂNG NHẬP";
            // 
            // btnDangnhap
            // 
            btnDangnhap.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.Location = new Point(373, 350);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(152, 76);
            btnDangnhap.TabIndex = 1;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += Login;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(588, 350);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(152, 76);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 298);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnDangnhap);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "ĐĂNG NHẬP HỆ THỐNG";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private TextBox txtPass;
        private Label label2;
        private TextBox txtTendangnhap;
        private Label label1;
        private Button btnDangnhap;
        private Button btnThoat;
        private PictureBox pictureBox1;
    }
}
namespace QL_HOANDON
{
    partial class FormDSTaiKhoan
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
            label7 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            txtSoTK = new TextBox();
            btnThemTK = new Button();
            btnRefrehTK = new Button();
            btnXoaTK = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(135, 42);
            label7.Name = "label7";
            label7.Size = new Size(344, 38);
            label7.TabIndex = 30;
            label7.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(593, 252);
            dataGridView1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnXoaTK);
            panel1.Controls.Add(btnRefrehTK);
            panel1.Controls.Add(btnThemTK);
            panel1.Controls.Add(txtSoTK);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(728, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 252);
            panel1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 33;
            label1.Text = "SỐ TÀI KHOẢN";
            // 
            // txtSoTK
            // 
            txtSoTK.Location = new Point(180, 38);
            txtSoTK.Name = "txtSoTK";
            txtSoTK.Size = new Size(125, 27);
            txtSoTK.TabIndex = 34;
            // 
            // btnThemTK
            // 
            btnThemTK.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemTK.Location = new Point(3, 98);
            btnThemTK.Name = "btnThemTK";
            btnThemTK.Size = new Size(132, 67);
            btnThemTK.TabIndex = 35;
            btnThemTK.Text = "Thêm tài khoản";
            btnThemTK.UseVisualStyleBackColor = true;
            btnThemTK.Click += button1_Click;
            // 
            // btnRefrehTK
            // 
            btnRefrehTK.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefrehTK.Location = new Point(3, 171);
            btnRefrehTK.Name = "btnRefrehTK";
            btnRefrehTK.Size = new Size(132, 61);
            btnRefrehTK.TabIndex = 36;
            btnRefrehTK.Text = "Refesh tải khoản";
            btnRefrehTK.UseVisualStyleBackColor = true;
            // 
            // btnXoaTK
            // 
            btnXoaTK.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaTK.Location = new Point(180, 98);
            btnXoaTK.Name = "btnXoaTK";
            btnXoaTK.Size = new Size(136, 67);
            btnXoaTK.TabIndex = 37;
            btnXoaTK.Text = "Xóa tài khoản";
            btnXoaTK.UseVisualStyleBackColor = true;
            btnXoaTK.Click += btnXoaTK_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Location = new Point(180, 171);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(136, 61);
            btnThoat.TabIndex = 38;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // FormDSTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Name = "FormDSTaiKhoan";
            Text = "QUẢN LÍ TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Button btnThoat;
        private Button btnXoaTK;
        private Button btnRefrehTK;
        private Button btnThemTK;
        private TextBox txtSoTK;
    }
}
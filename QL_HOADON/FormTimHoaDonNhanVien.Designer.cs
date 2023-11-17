namespace QL_HOADON
{
    partial class FormTimHoaDonNhanVien
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
            comboBox1 = new ComboBox();
            label9 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(91, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(26, 11);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 0;
            label9.Text = "Chọn / Nhập mã nhân viên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(91, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(138, 31);
            button2.Name = "button2";
            button2.Size = new Size(109, 60);
            button2.TabIndex = 1;
            button2.Text = "THOÁT";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 31);
            button1.Name = "button1";
            button1.Size = new Size(109, 60);
            button1.TabIndex = 0;
            button1.Text = "TÌM KIẾM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SearchHoaDonFromNhanVien;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Violet;
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(383, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(648, 466);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 299);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(612, 147);
            dataGridView1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(185, 268);
            label8.Name = "label8";
            label8.Size = new Size(277, 28);
            label8.TabIndex = 13;
            label8.Text = "DANH SÁCH CÁC HÓA ĐƠN";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(109, 146);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(205, 27);
            textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(109, 212);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(205, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(425, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(425, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(425, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(329, 212);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Mã  phòng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(329, 146);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Hệ số lương";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(329, 88);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Phái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 209);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "HS chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 146);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 24);
            label1.Name = "label1";
            label1.Size = new Size(338, 38);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // FormTimHoaDonNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 523);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormTimHoaDonNhanVien";
            Text = "TÌM KIẾM HÓA ĐƠN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label9;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label8;
    }
}
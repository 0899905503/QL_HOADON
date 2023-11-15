namespace QL_HOANDON
{
    partial class FormQLHanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLHanghoa));
            panel1 = new Panel();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            c = new Panel();
            btnThoat = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            c.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(61, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 150);
            panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(618, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker1.Location = new Point(185, 105);
            dateTimePicker1.Name = "dateTimePicker2";
            dateTimePicker1.Size = new Size(196, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(618, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(477, 110);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 3;
            label3.Text = "Đơn giá";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(477, 26);
            label4.Name = "label4";
            label4.Size = new Size(81, 22);
            label4.TabIndex = 4;
            label4.Text = "Tên hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 29);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 1;
            label1.Text = "Mã hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 105);
            label2.Name = "label2";
            label2.Size = new Size(129, 22);
            label2.TabIndex = 2;
            label2.Text = " Ngày  sản xuất";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(889, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // c
            // 
            c.BackColor = Color.Gold;
            c.Controls.Add(btnThoat);
            c.Controls.Add(btnXoa);
            c.Controls.Add(btnLuu);
            c.Controls.Add(btnSua);
            c.Controls.Add(btnThem);
            c.Location = new Point(61, 414);
            c.Name = "c";
            c.Size = new Size(889, 85);
            c.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(734, 20);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 48);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
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
            btnSua.Click += btnSua_Click;
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
            btnThem.Click += btnThem_Click;
            // 
            // FormQLHanghoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 511);
            Controls.Add(c);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormQLHanghoa";
            Text = "DANH MUC HÀNG HÓA";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            c.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel c;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnSua;
        private Button btnThem;
    }
}
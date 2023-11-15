using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace QL_HOADON
{
    public partial class FormTimKiemHoaDon : Form
    {
        public FormTimKiemHoaDon()
        {
            InitializeComponent();
        }
        public void SearchHoaDon(object sender, EventArgs e)
        {
            var hoadonID = comboBox1.Text;
            if (hoadonID == null)
            {
                MessageBox.Show($"Hoa don ID la truong bat buoc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string queryString = @"SELECT * FROM HOADON WHERE SOHD = @MaHD";
                    Database.SQLConnect.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaHD", hoadonID);
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                    textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    Database.SQLConnect.Close();

                    string queryString2 = @"SELECT SUM(CTHOADON.SOLUONG * HANGHOA.DONGIA) as tonghoadon FROM HOADON
                    JOIN CTHOADON on CTHOADON.SOHD = HOADON.SOHD
                    JOIN HANGHOA on HANGHOA.MAHH = CTHOADON.MAHH
                     WHERE HOADON.SOHD = @MaHD";
                    Database.SQLConnect.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = Database.SQLConnect;
                    sqlCommand.CommandText = queryString2;
                    sqlCommand.Parameters.AddWithValue("@MaHD", hoadonID);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox5.Text = reader.GetDouble("tonghoadon").ToString();
                    }
                    Database.SQLConnect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

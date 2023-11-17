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
            LoadForm();
        }

        public void LoadForm()
        {
            try
            {
                string queryString = "SELECT SOHD FROM HOADON";
                Database.SQLConnect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SQLConnect;
                sqlCommand.CommandText = queryString;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("SOHD"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SQLConnect.Close();
            }
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Database.SQLConnect.Close();
                }
                try
                {
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
                        if (!reader.IsDBNull("tonghoadon"))
                        {
                            double value = reader.GetDouble("tonghoadon");
                            textBox5.Text = value.ToString();
                        }

                        else textBox5.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Database.SQLConnect.Close();
                }
            }
        }

    }
}

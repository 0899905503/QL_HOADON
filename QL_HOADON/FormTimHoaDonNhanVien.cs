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
    public partial class FormTimHoaDonNhanVien : Form
    {
        public FormTimHoaDonNhanVien()
        {
            InitializeComponent();
            LoadNhanVienID();
        }
        public void LoadNhanVienID()
        {
            try
            {
                string queryString = "SELECT MANV FROM NHANVIEN";
                Database.SQLConnect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SQLConnect;
                sqlCommand.CommandText = queryString;
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString("MANV"));
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

        public void SearchHoaDonFromNhanVien(object sender, EventArgs e)
        {
            var NHANVIENID = comboBox1.Text;
            if (NHANVIENID == null)
            {
                MessageBox.Show($"Nhan vien ID la truong bat buoc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string queryString = @"SELECT * FROM NHANVIEN WHERE MANV = @MaNV";
                    Database.SQLConnect.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaNV", NHANVIENID);
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                    textBox1.Text = dataGridView1.Rows[0].Cells[4].Value.ToString() == "1" ? "nam" : "nu";
                    textBox2.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    textBox3.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    textBox4.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    textBox5.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                    textBox6.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
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
                    string queryString = "SELECT * FROM HOADON WHERE MANV = @NVID";
                    Database.SQLConnect.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@NVID", NHANVIENID);
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
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

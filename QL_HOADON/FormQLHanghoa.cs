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

namespace QL_HOANDON
{
    public partial class FormQLHanghoa : Form
    {
        public FormQLHanghoa()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "SELECT * FROM HANGHOA";
                Database.SQLConnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value from the clicked cell
                var Mahang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                var Tenhang = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var Dongia = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                var Ngaysanxuat = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox1.Text = Mahang;
                textBox2.Text = Tenhang;
                textBox3.Text = Dongia;
                dateTimePicker1.Text = Ngaysanxuat;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                if (dataGridView1.SelectedRows.Count == dataGridView1.Rows.Count) return;
                var Mahang = selectedRow.Cells[0].Value.ToString();
                var Tenhang = selectedRow.Cells[1].Value.ToString();
                var Dongia = selectedRow.Cells[2].Value.ToString();
                var Ngaysanxuat = selectedRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = Ngaysanxuat;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var Mahang = textBox1.Text;
            var Tenhang = textBox2.Text;
            var Dongia = textBox3.Text;
            var Ngaysanxuat = dateTimePicker1.Text;
            bool haveValue = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value?.ToString() == Mahang)
                {
                    haveValue = true;
                    break;
                }
            }
            try
            {
                Database.SQLConnect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SQLConnect;
                if (haveValue == true)
                {
                    string queryString = @"UPDATE HANGHOA SET TENHH = @Tenhang,
                                        DONGIA = @Dongia,NGAYSX = @Ngaysanxuat WHERE MAHH = @Mahang";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@Mahang", Mahang);
                    sqlCommand.Parameters.AddWithValue("@Tenhang", Tenhang);
                    sqlCommand.Parameters.AddWithValue("@Dongia", Dongia);
                    sqlCommand.Parameters.AddWithValue("@Ngaysanxuat", Ngaysanxuat);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật hàng hóa" + Mahang);
                }
                else
                {
                    string queryString = @"INSERT INTO HANGHOA
                                        VALUES (@Mahang, @Tenhang, @Dongia, @Ngaysanxuat)";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@Mahang", Mahang);
                    sqlCommand.Parameters.AddWithValue("@Tenhang", Tenhang);
                    sqlCommand.Parameters.AddWithValue("@Dongia", Dongia);
                    sqlCommand.Parameters.AddWithValue("@Ngaysanxuat", Ngaysanxuat);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã lưu mới hàng hóa" + Mahang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SQLConnect.Close();
                LoadForm();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowsDeleted = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var Mahang = row.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(Mahang))
                {
                    try
                    {
                        string deleteQuery = @"DELETE FROM HANGHOA WHERE MAHANG = @Mahang";
                        Database.SQLConnect.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = Database.SQLConnect;
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.Parameters.AddWithValue("@Mahang", Mahang);
                        sqlCommand.ExecuteNonQuery();
                        rowsDeleted++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        Database.SQLConnect.Close();
                        LoadForm();
                    }
                }
            }
            MessageBox.Show("Đã xóa " + rowsDeleted + " hàng hóa");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            dateTimePicker1.ResetText();
            textBox1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult Traloi;
            Traloi = MessageBox.Show("Bạn có chắc thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Traloi == DialogResult.Yes)
                this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Database.SQLConnect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SQLConnect;
                string queryString = @"UPDATE HANGHOA SET TENHH = @Tenhang,
                                        DONGIA = @Dongia,NGAYSX = @Ngaysanxuat WHERE MAHH = @Mahang";
                sqlCommand.CommandText = queryString;
                sqlCommand.Parameters.Add("@Mahang", SqlDbType.NVarChar).Value = textBox1.Text;
                sqlCommand.Parameters.Add("@Tenhang", SqlDbType.NVarChar).Value = textBox2.Text;
                sqlCommand.Parameters.Add("@Dongia", SqlDbType.Float).Value = textBox3.Text;
                sqlCommand.Parameters.Add("@Ngaysanxuat", SqlDbType.Date).Value = dateTimePicker1.Text;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SQLConnect.Close();
                LoadForm();
           }

        } 

    }
}

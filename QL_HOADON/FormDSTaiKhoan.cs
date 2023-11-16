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
using QL_HOADON;

namespace QL_HOANDON
{
    public partial class FormDSTaiKhoan : Form
    {
        public FormDSTaiKhoan()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadForm()
        {
            try
            {
                string queryString = "SELECT * FROM TAIKHOAN";
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

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormThemTaiKhoan();
            form.Show();
            this.Hide();
            this.Closed += (s, args) => this.Close();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            var rowsDeleted = 0;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var User_name = row.Cells[0].Value?.ToString();
                if (!string.IsNullOrEmpty(User_name))
                {
                    try
                    {
                        string deleteQuery = @"DELETE FROM TAIKHOAN WHERE USER_NAME = @User_name";
                        Database.SQLConnect.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = Database.SQLConnect;
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.Parameters.AddWithValue("@User_name", User_name);
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
            MessageBox.Show("Đã xóa " + rowsDeleted + " tài khoản");
        }
    }
}

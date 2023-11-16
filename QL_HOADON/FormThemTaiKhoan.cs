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
    public partial class FormThemTaiKhoan : Form
    {
        public FormThemTaiKhoan()
        {
            InitializeComponent();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var User_Name = textBoxUserName.Text;
            var Name = textBoxTenTaiKhoan.Text;
            var Password = txtPass.Text;
            var Quyen = cbBoxQuyen.Text;

            try
            {
                Database.SQLConnect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SQLConnect;
                string queryString = @"INSERT INTO TAIKHOAN (USER_NAME, PASSWORD, NAME, PERMISSON)
                                    VALUES  (@User_Name, @Password, @Name, @Quyen)";
                sqlCommand.CommandText = queryString;
                sqlCommand.Parameters.AddWithValue("@User_Name", User_Name);
                sqlCommand.Parameters.AddWithValue("@Password", Password);
                sqlCommand.Parameters.AddWithValue("@Name", Name);
                sqlCommand.Parameters.AddWithValue("@Quyen", Quyen);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Đã lưu tài khoản mới");

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

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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnDangnhap;
        }
        public void Login(object sender, EventArgs e)
        {
            var username = txtTendangnhap.Text;
            var password = txtPass.Text;
            try
            {
                var queryString = @"SELECT * FROM TAIKHOAN
                                WHERE USER_NAME = @username AND PASSWORD = @password";
                Database.SQLConnect.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = Database.SQLConnect;
                sqlCommand.CommandText = queryString;
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    AppData.user = new User(
                    reader.GetString("USER_NAME"),
                    reader.GetString("NAME"),
                    reader.GetString("PASSWORD"),
                    reader.GetString("PERMISSON")
                    );
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
            if (AppData.user != null)
            {
                foreach (Form form in Application.OpenForms.Cast<Form>())
                {
                    // MessageBox.Show(form.ToString());
                    form.Hide();
                    form.Closed += (s, args) => this.Close();
                }
                var formMain = new FormMain();
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

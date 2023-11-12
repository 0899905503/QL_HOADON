using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HOANDON
{
    public partial class FormQuanLiNhanVien : Form
    {
        public FormQuanLiNhanVien()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "SELECT * FROM NHANVIEN";
                Database.SQLConnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvquanlynhanvien.DataSource = table;
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

        private void dgvquanlynhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value from the clicked cell
                var Manv = dgvquanlynhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                var Hoten = dgvquanlynhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                var Phai = dgvquanlynhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                var Ngaysinh = dgvquanlynhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                var Hsluong = dgvquanlynhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                var Hschucvu = dgvquanlynhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                var Maphongnv = dgvquanlynhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtManv.Text = Manv;
                txtHotennv.Text = Hoten;
                txtPhai.Text = Phai;
                txtNgaysinh.Text = Ngaysinh;
                txtHesoluong.Text = Hsluong;
                txtHesochucvu.Text = Hschucvu;
                txtMaphong.Text = Maphongnv;
            }
        }
        private void dgvquanlynhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvquanlynhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvquanlynhanvien.SelectedRows[0];
                if (dgvquanlynhanvien.SelectedRows.Count == dgvquanlynhanvien.Rows.Count) return;
                var Manv = selectedRow.Cells[0].Value.ToString();
                var Hoten = selectedRow.Cells[1].Value.ToString();
                var Phai = selectedRow.Cells[2].Value.ToString();
                var Ngaysinh = selectedRow.Cells[3].Value.ToString();
                var Hsluong = selectedRow.Cells[4].Value.ToString();
                var Hschucvu = selectedRow.Cells[5].Value.ToString();
                var Maphongnv = selectedRow.Cells[6].Value.ToString();
                txtManv.Text = Manv;
                txtHotennv.Text = Hoten;
                txtPhai.Text = Phai;
                txtNgaysinh.Text = Ngaysinh;
                txtHesoluong.Text = Hsluong;
                txtHesochucvu.Text = Hschucvu;
                txtMaphongnv.Text = Maphongnv;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var Manv = txtManv.Text;
            var Hoten = txtHotennv.Text;
            var Phai = txtPhai.Text;
            var Ngaysinh = txtNgaysinh.Text;
            var Hsluong = txtHesoluong.Text;
            var Hschucvu = txtHesochucvu.Text;
            var Maphongnv = txtMaphongnv.Text;
            bool haveValue = false;
            foreach (DataGridViewRow row in dgvquanlynhanvien.Rows)
            {
                if (row.Cells[0].Value?.ToString() == Manv)
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
                    string queryString = @"UPDATE NHANVIEN
                                        SET HOTEN = @HOTEN,
                                        PHAI = @PHAI, 
                                        NGAYSINH = @NGAYSINH
                                        HSLUONG = @HSLUONG
                                        HSCHUCVU = @HSCHUCVU
                                        MAPHONGNV = @MAPHONG
                                        WHERE MANV = @MANV";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MANV", Manv);
                    sqlCommand.Parameters.AddWithValue("@HOTEN", Hoten);
                    sqlCommand.Parameters.AddWithValue("@PHAI", Phai);
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", Ngaysinh);
                    sqlCommand.Parameters.AddWithValue("@HSLUONG", Hsluong);
                    sqlCommand.Parameters.AddWithValue("@HSCHUCVU", Hschucvu);
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", Maphongnv);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật thông tin nhân viên " + Manv);
                }
                else
                {
                    string queryString = @"INSERT INTO NHANVIEN
                                        VALUES (@MANV,@HOTEN,@PHAI,@NGAYSINH,@HSLUONG,@HSCHUCVU,@MAPHONG)";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MANV", Manv);
                    sqlCommand.Parameters.AddWithValue("@HOTEN", Hoten);
                    sqlCommand.Parameters.AddWithValue("@PHAI", Phai);
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", Ngaysinh);
                    sqlCommand.Parameters.AddWithValue("@HSLUONG", Hsluong);
                    sqlCommand.Parameters.AddWithValue("@HSCHUCVU", Hschucvu);
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", Maphongnv);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã lưu mới thông tin nhân viên " + Manv);
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
            foreach (DataGridViewRow row in dgvquanlynhanvien.SelectedRows)
            {
                var Manv = row.Cells[0]?.Value.ToString();
                if (!string.IsNullOrEmpty(Manv))
                {
                    try
                    {
                        string deleteQuery = @"DELETE FROM NHANVIEN WHERE MANV = @MANV";
                        Database.SQLConnect.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = Database.SQLConnect;
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.Parameters.AddWithValue("@MANV", Manv);
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
            MessageBox.Show("Đã xóa " + rowsDeleted + " nhân viên");
        }
    }
}

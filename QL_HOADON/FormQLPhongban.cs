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
    public partial class FormQLPhongban : Form
    {
        public FormQLPhongban()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "SELECT * FROM PHONGBAN";
                Database.SQLConnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvThongtinphongban.DataSource = table;
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

        private void dgvThongtinphongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value from the clicked cell
                var MaPhong = dgvThongtinphongban.Rows[e.RowIndex].Cells[0].Value.ToString();
                var TenPhong = dgvThongtinphongban.Rows[e.RowIndex].Cells[1].Value.ToString();
                var DienThoai = dgvThongtinphongban.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaphong.Text = MaPhong;
                txtTenphong.Text = TenPhong;
                txtSdt.Text = DienThoai;
            }
        }
        private void dgvThongtinphongban_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThongtinphongban.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvThongtinphongban.SelectedRows[0];
                if (dgvThongtinphongban.SelectedRows.Count == dgvThongtinphongban.Rows.Count) return;
                var MaPhong = selectedRow.Cells[0].Value.ToString();
                var TenPhong = selectedRow.Cells[1].Value.ToString();
                var DienThoai = selectedRow.Cells[2].Value.ToString();
                txtMaphong.Text = MaPhong;
                txtTenphong.Text = TenPhong;
                txtSdt.Text = DienThoai;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var MaPhong = txtMaphong.Text;
            var TenPhong = txtTenphong.Text;
            var DienThoai = txtSdt.Text;
            bool haveValue = false;
            foreach (DataGridViewRow row in dgvThongtinphongban.Rows)
            {
                if (row.Cells[0].Value?.ToString() == MaPhong)
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
                    string queryString = @"UPDATE PHONGBAN
                                        SET TENPHONG = @TenPhong,
                                        DIENTHOAI = @DienThoai
                                        WHERE MAPHONG = @MaPhong";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MaPhong", MaPhong);
                    sqlCommand.Parameters.AddWithValue("@TenPhong", TenPhong);
                    sqlCommand.Parameters.AddWithValue("@DienThoai", DienThoai);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã cập nhật phòng ban " + MaPhong);
                }
                else
                {
                    string queryString = @"INSERT INTO PHONGBAN
                                        VALUES (@MaPhong, @TenPhong, @DienThoai)";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MaPhong", MaPhong);
                    sqlCommand.Parameters.AddWithValue("@TenPhong", TenPhong);
                    sqlCommand.Parameters.AddWithValue("@DienThoai", DienThoai);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã lưu mới phòng ban " + MaPhong);
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
            foreach (DataGridViewRow row in dgvThongtinphongban.SelectedRows)
            {
                var MaPhong = row.Cells[0]?.Value.ToString();
                if (!string.IsNullOrEmpty(MaPhong))
                {
                    try
                    {
                        string deleteQuery = @"DELETE FROM PHONGBAN WHERE MAPHONG = @MaPhong";
                        Database.SQLConnect.Open();
                        SqlCommand sqlCommand = new SqlCommand();
                        sqlCommand.Connection = Database.SQLConnect;
                        sqlCommand.CommandText = deleteQuery;
                        sqlCommand.Parameters.AddWithValue("@MaPhong", MaPhong);
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
            MessageBox.Show("Đã xóa " + rowsDeleted + " phòng ban");
        }
    }
}

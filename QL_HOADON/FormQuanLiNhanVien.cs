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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_HOANDON
{
    public partial class FormQuanLiNhanVien : Form
    {
        public FormQuanLiNhanVien()
        {
            InitializeComponent();
            LoadForm();
            LoadDL_MaPhong();
        }
        private void LoadForm()
        {
            try
            {
                string queryString = "SELECT MANV, HOTEN, CASE WHEN PHAI = 1 THEN N'nam' ELSE N'nữ' END AS PHAI, NGAYSINH, HSLUONG, HSCHUCVU, MAPHONG FROM NHANVIEN";
                Database.SQLConnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvquanlinhanvien.DataSource = table;
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
            if (e.RowIndex >= 0)
            {

                var Manv = dgvquanlinhanvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                var Hoten = dgvquanlinhanvien.Rows[e.RowIndex].Cells[1].Value.ToString();
                var Phai = dgvquanlinhanvien.Rows[e.RowIndex].Cells[2].Value.ToString();
                var Ngaysinh = dgvquanlinhanvien.Rows[e.RowIndex].Cells[3].Value.ToString();
                var Hsluong = dgvquanlinhanvien.Rows[e.RowIndex].Cells[4].Value.ToString();
                var Hschucvu = dgvquanlinhanvien.Rows[e.RowIndex].Cells[5].Value.ToString();
                var Maphong = dgvquanlinhanvien.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtManv.Text = Manv;
                txtHotennv.Text = Hoten;
                cbbPhai.Text = Phai;
                cbbngaysinh.Text = Ngaysinh;
                txtHesoluong.Text = Hsluong;
                txtHesochucvu.Text = Hschucvu;
                cbbmaphong.Text = Maphong;
                dateTimePicker1.Text = Ngaysinh;
            }
            try
            {
                //if (dgvquanlinhanvien.SelectedRows.Count > 0)
                //{
                //    // Lấy dòng được chọn
                //    DataGridViewRow selectedRow = dgvquanlinhanvien.SelectedRows[0];

                //    DataGridViewRow row = this.dgvquanlinhanvien.Rows[e.RowIndex];
                //    // Get the value from the clicked cell
                //    txtManv.Text = row.Cells["manv"].Value.ToString();
                //    txtHotennv.Text = row.Cells["hoten"].Value.ToString();
                //    cbbPhai.Text = row.Cells["phai"].Value.ToString();
                //    txtHesoluong.Text = row.Cells["hsluong"].Value.ToString();
                //    txtHesochucvu.Text = row.Cells["hschucvu"].Value.ToString();
                //    dateTimePicker1.Text = row.Cells["ngaysinh"].Value.ToString();
                //    cbbmaphong.Text = row.Cells["maphong"].Value.ToString();
                //    //string cellManv = selectedRow.Cells["manv"].Value.ToString();
                //    //string cellHoten = selectedRow.Cells["hoten"].Value.ToString();
                //    //string cellPhai = selectedRow.Cells["phai"].Value.ToString();
                //    //string cellNgaysinh = selectedRow.Cells["ngaysinh"].Value.ToString();
                //    //string cellHsluong = selectedRow.Cells["hsluong"].Value.ToString();
                //    //string cellHschucvu = selectedRow.Cells["hschucvu"].Value.ToString();
                //    //string cellMaphong = selectedRow.Cells["maphong"].Value.ToString();
                //    // Hiển thị giá trị trong TextBox
                //    txtManv.Text = cellManv;
                //    txtHotennv.Text = cellHoten;
                //    cbbPhai.Text = cellPhai;
                //    dateTimePicker1.Text = cellNgaysinh;
                //    txtHesoluong.Text = cellHsluong;
                //    txtHesochucvu.Text = cellHschucvu;
                //    cbbmaphong.Text = cellMaphong;
                //}
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow selectedRow = dgvquanlinhanvien.Rows[e.RowIndex];

                    txtManv.Text = selectedRow.Cells["MANV"].Value.ToString();
                    txtHotennv.Text = selectedRow.Cells["HOTEN"].Value.ToString();
                    dateTimePicker1.Text = selectedRow.Cells["NGAYSINH"].Value.ToString();
                    cbbPhai.Text = selectedRow.Cells["PHAI"].Value.ToString();
                    txtHesoluong.Text = selectedRow.Cells["HSLUONG"].Value.ToString();
                    txtHesochucvu.Text = selectedRow.Cells["HSCHUCVU"].Value.ToString();
                    txtTienluong.Text = selectedRow.Cells["TIENLUONG"].Value.ToString();
                    cbbmaphong.Text = selectedRow.Cells["MAPHONG"].Value.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
            finally
            {
                Database.SQLConnect.Close();
                LoadForm();
            }
        }
        private void dgvquanlynhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvquanlinhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvquanlinhanvien.SelectedRows[0];
                if (dgvquanlinhanvien.SelectedRows.Count == dgvquanlinhanvien.Rows.Count) return;
                var Manv = selectedRow.Cells[0].Value.ToString();
                var Hoten = selectedRow.Cells[1].Value.ToString();
                var Phai = selectedRow.Cells[2].Value.ToString();
                var Ngaysinh = selectedRow.Cells[3].Value.ToString();
                var Hsluong = selectedRow.Cells[4].Value.ToString();
                var Hschucvu = selectedRow.Cells[5].Value.ToString();
                var Maphong = selectedRow.Cells[6].Value.ToString();
                txtManv.Text = Manv;
                txtHotennv.Text = Hoten;
                cbbPhai.Text = Phai;
                cbbngaysinh.Text = Ngaysinh;
                txtHesoluong.Text = Hsluong;
                txtHesochucvu.Text = Hschucvu;
                cbbmaphong.Text = Maphong;
                dateTimePicker1.Text = Ngaysinh;
            }
        }


        private void LoadDL_MaPhong()
        {
            string sql = "select MAPHONG from PHONGBAN";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.SQLConnect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbbmaphong.DataSource = dt;
            cbbmaphong.DisplayMember = "MAPHONG";
            cbbmaphong.ValueMember = "MAPHONG";
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            var Manv = txtManv.Text;
            var Hoten = txtHotennv.Text;
            var Phai = cbbPhai.Text;
            var Ngaysinh = dateTimePicker1.Text;
            var Hsluong = txtHesoluong.Text;
            var Hschucvu = txtHesochucvu.Text;
            var Maphong = cbbmaphong.Text;
            bool haveValue = false;
            foreach (DataGridViewRow row in dgvquanlinhanvien.Rows)
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
                                        NGAYSINH = @NGAYSINH,
                                        HSLUONG = @HSLUONG,
                                        HSCHUCVU = @HSCHUCVU,
                                        Maphong = @MAPHONG
                                        WHERE MANV = @MANV";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MANV", Manv);
                    sqlCommand.Parameters.AddWithValue("@HOTEN", Hoten);
                    sqlCommand.Parameters.AddWithValue("@PHAI", Phai);
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", Ngaysinh);
                    sqlCommand.Parameters.AddWithValue("@HSLUONG", Hsluong);
                    sqlCommand.Parameters.AddWithValue("@HSCHUCVU", Hschucvu);
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", Maphong);
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
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", Maphong);
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
            foreach (DataGridViewRow row in dgvquanlinhanvien.SelectedRows)
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

        private void txtManv_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbngaysinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManv.Enabled = true;
            txtHotennv.Enabled = true;
            txtHesoluong.Enabled = true;
            txtHesochucvu.Enabled = true;
            cbbPhai.Enabled = true;
            txtTienluong.Enabled = true;
            cbbmaphong.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtManv.ResetText();
            txtHotennv.ResetText();
            txtHesoluong.ResetText();
            txtHesochucvu.ResetText();
            cbbPhai.ResetText();
            txtTienluong.ResetText();
            cbbmaphong.ResetText();
            dateTimePicker1.ResetText();
            txtManv.Focus();
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
                string queryString = @"UPDATE NHANVIEN SET Hoten = @Hoten,
                                        Phai = @Phai,Ngaysinh = @Ngaysinh,
                                   Hesoluong = @Hesoluong, Tienluong = @Tienluong,
                                               Hesoluong = @Hesoluong,WHERE Manv = @Manv";
                sqlCommand.CommandText = queryString;
                sqlCommand.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = txtManv.Text;
                sqlCommand.Parameters.Add("@Hoten", SqlDbType.NVarChar).Value = txtHotennv.Text;
                sqlCommand.Parameters.Add("@Phai", SqlDbType.Float).Value = cbbPhai.Text;
                sqlCommand.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = dateTimePicker1.Text;
                sqlCommand.Parameters.Add("@Hesoluong", SqlDbType.Float).Value = txtHesoluong.Text;
                sqlCommand.Parameters.Add("@Tienluong", SqlDbType.Float).Value = txtTienluong.Text;
                sqlCommand.Parameters.Add("@Hesochucvu", SqlDbType.Float).Value = txtHesochucvu.Text;
                sqlCommand.Parameters.Add("@", SqlDbType.Float).Value = cbbPhai.Text;
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

        private void btnLuuSua_Click(object sender, EventArgs e)
        {
            var Manv = txtManv.Text;
            var Hoten = txtHotennv.Text;
            var Phai = cbbPhai.Text;
            var Ngaysinh = dateTimePicker1.Text;
            var Hsluong = txtHesoluong.Text;
            var Hschucvu = txtHesochucvu.Text;
            var Maphong = cbbmaphong.Text;
            bool haveValue = false;
            foreach (DataGridViewRow row in dgvquanlinhanvien.Rows)
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
                                        Maphong = @MAPHONG
                                        WHERE MANV = @MANV";
                    sqlCommand.CommandText = queryString;
                    sqlCommand.Parameters.AddWithValue("@MANV", Manv);
                    sqlCommand.Parameters.AddWithValue("@HOTEN", Hoten);
                    sqlCommand.Parameters.AddWithValue("@PHAI", Phai);
                    sqlCommand.Parameters.AddWithValue("@NGAYSINH", Ngaysinh);
                    sqlCommand.Parameters.AddWithValue("@HSLUONG", Hsluong);
                    sqlCommand.Parameters.AddWithValue("@HSCHUCVU", Hschucvu);
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", Maphong);
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
                    sqlCommand.Parameters.AddWithValue("@MAPHONG", Maphong);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        //private void dgvquanlinhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if (dgvquanlinhanvien.SelectedRows.Count > 0)
        //        {
        //            // Lấy dòng được chọn
        //            DataGridViewRow selectedRow = dgvquanlinhanvien.SelectedRows[0];

        //            // Lấy giá trị từ cột mong muốn (ở đây là cột có tên "TenCot")
        //            string cellManv = selectedRow.Cells["manv"].Value.ToString();
        //            string cellHoten = selectedRow.Cells["hoten"].Value.ToString();
        //            string cellPhai = selectedRow.Cells["phai"].Value.ToString();
        //            string cellNgaysinh = selectedRow.Cells["ngaysinh"].Value.ToString();
        //            string cellHsluong = selectedRow.Cells["hsluong"].Value.ToString();
        //            string cellHschucvu = selectedRow.Cells["hschucvu"].Value.ToString();
        //            string cellMaphong = selectedRow.Cells["maphong"].Value.ToString();
        //            // Hiển thị giá trị trong TextBox
        //            txtManv.Text = cellManv;
        //            txtHotennv.Text = cellHoten;
        //            cbbPhai.Text = cellPhai;
        //            dateTimePicker1.Text = cellNgaysinh;
        //            txtHesoluong.Text = cellHsluong;
        //            txtHesochucvu.Text = cellHschucvu;
        //            cbbmaphong.Text = cellMaphong;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Chọn dòng để hiển thị");
        //    }
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}

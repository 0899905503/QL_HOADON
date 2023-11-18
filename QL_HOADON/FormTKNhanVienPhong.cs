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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_HOADON
{
    public partial class FormTKNhanVienPhong : Form
    {
        public FormTKNhanVienPhong()
        {
            InitializeComponent();
            LoadForm();
            LoadDL_MaPhong();
            CountNhanVien();
            TotalSalary();
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
                dgvtknhanvienphong.DataSource = table;
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
        private void dgvtknhanvienphong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvtknhanvienphong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvtknhanvienphong.SelectedRows[0];
                if (dgvtknhanvienphong.SelectedRows.Count == dgvtknhanvienphong.Rows.Count) return;
                var Maphong = selectedRow.Cells[0].Value.ToString();
                var Tenphong = selectedRow.Cells[1].Value.ToString();
                var Dienthoai = selectedRow.Cells[2].Value.ToString();
            }
        }
        private void dgvquanlynhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var MAPHONG = cbbmaphong.Text;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value from the clicked cell
                var Maphong = dgvtknhanvienphong.Rows[e.RowIndex].Cells[0].Value.ToString();
                var Tenphong = dgvtknhanvienphong.Rows[e.RowIndex].Cells[1].Value.ToString();
                var Dienthoai = dgvtknhanvienphong.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbmaphong.Text = Maphong;
                txttenphong.Text = Tenphong;
                txtdienthoai.Text = Dienthoai;
            }
            try
            {
                string queryString = "SELECT TENPHON, DIENTHOAI  FROM PHONGBAN WHERE MAPHONG = @MAPHONG";
                Database.SQLConnect.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MAPHONG", MAPHONG);
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                dgvtknhanvienphong.DataSource = table;
                txttenphong.Text = table.Rows[0].ToString();
                txtdienthoai.Text = table.Rows[1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Database.SQLConnect.Close();
            }
            CountNhanVien();
        }
        // ham den nhan vien
        private void CountNhanVien()
        {
            int count = dgvtknhanvienphong.RowCount;
            txtsonhanvien.Text = count.ToString();
        }

        private void cbbmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select MANV, HOTEN,(CASE WHEN PHAI = 1 THEN N'Nam' ELSE N'Nữ' END) as PHAI, NGAYSINH,HSLUONG,HSCHUCVU,(HSLUONG * 1390000 + HSCHUCVU * 1390000) AS TIENLUONG
                            from NHANVIEN INNER JOIN PHONGBAN ON NHANVIEN.MAPHONG = PHONGBAN.MAPHONG where PHONGBAN.MAPHONG = '" + cbbmaphong.SelectedValue.ToString() + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, Database.SQLConnect);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgvtknhanvienphong.DataSource = dt;
            txttenphong.Text = TenPhongBan(cbbmaphong.SelectedValue.ToString());
            txtdienthoai.Text = SoDienThoai(cbbmaphong.SelectedValue.ToString());
            CountNhanVien();
        }
        public string TenPhongBan(string maPhong)
        {
            if (Database.SQLConnect.State == ConnectionState.Open) Database.SQLConnect.Close();
            Database.SQLConnect.Open();
            SqlCommand cmd = new SqlCommand("SELECT TENPHONG FROM PHONGBAN WHERE MAPHONG = @MAPHONG", Database.SQLConnect);
            cmd.Parameters.AddWithValue("@MAPHONG", maPhong);
            object result = cmd.ExecuteScalar();
            Database.SQLConnect.Close();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return "";
            }
        }
        public string SoDienThoai(string maPhong)
        {
            if (Database.SQLConnect.State == ConnectionState.Open) Database.SQLConnect.Close();
            Database.SQLConnect.Open();
            SqlCommand cmd = new SqlCommand("select DIENTHOAI from PHONGBAN where MAPHONG = @MAPHONG", Database.SQLConnect);
            cmd.Parameters.AddWithValue("@MAPHONG", maPhong);
            object result = cmd.ExecuteScalar();
            Database.SQLConnect.Close();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return "";
            }
        }
        public void TotalSalary()
        {
            double tongluong = 0.0;
            for (int i = 0; i < dgvtknhanvienphong.Rows.Count; i++)
            {
                double luongNhanVien = Convert.ToDouble(dgvtknhanvienphong.Rows[i].Cells["TIENLUONG"].Value);
                tongluong += luongNhanVien;
            }

            txttongtienluong.Text = tongluong.ToString();
        }
    }
}

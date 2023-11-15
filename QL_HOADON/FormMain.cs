using Microsoft.Data.SqlClient;
using QL_HOANDON;

namespace QL_HOADON
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void quanLiPhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLPhongban form = new FormQLPhongban();

            form.Show();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
        }
        private void dangXuatToolStripMenuItem_CLick(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>())
            {
                form.Hide();
                form.Closed += (s, args) => this.Close();
            }
            var formLogin = new FormLogin();
            formLogin.Show();
        }

        private void quanLiHangHoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLHanghoa form = new FormQLHanghoa();
            form.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLiNhanVien form = new FormQuanLiNhanVien();
            form.Show();
        }

        private void quanLiHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLHoadon form = new FormQLHoadon();
            form.Show();
        }

        private void danhSachNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLiNhanVien form = new FormQuanLiNhanVien();
            form.Show();
        }

        private void thongKeTheoPhongBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTKNhanVienPhong form = new FormTKNhanVienPhong();
            form.Show();
        }

        private void timKiemHoaDonTheoNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimHoaDonNhanVien form = new FormTimHoaDonNhanVien();
            form.Show();
        }

        private void timKiemHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiemHoaDon form = new FormTimKiemHoaDon();
            form.Show();
        }

        private void danhSachTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSTaiKhoan form = new FormDSTaiKhoan();
            form.Show();
        }

        private void themTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan form = new FormThemTaiKhoan();
            form.Show();
        }
    }
}
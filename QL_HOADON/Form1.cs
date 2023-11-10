using QL_HOANDON;

namespace QL_HOADON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void quảnLíPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLPhongban form = new FormQLPhongban();

            form.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            form.Show();
        }

        private void quảnLíHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLHanghoa form = new FormQLHanghoa();
            form.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLiNhanVien form = new FormQuanLiNhanVien();
            form.Show();
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLHoadon form = new FormQLHoadon();
            form.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQuanLiNhanVien form = new FormQuanLiNhanVien();
            form.Show();
        }

        private void thốngKêNhânViênTheoPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTKNhanVienPhong form = new FormTKNhanVienPhong();
            form.Show();
        }

        private void tìmHóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimHoaDonNhanVien form = new FormTimHoaDonNhanVien();
            form.Show();
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimKiemHoaDon form = new FormTimKiemHoaDon();
            form.Show();
        }

        private void danhSáchTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDSTaiKhoan form = new FormDSTaiKhoan();
            form.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemTaiKhoan form = new FormThemTaiKhoan();
            form.Show();
        }
    }
}
namespace QL_HOADON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadForm();
        }
        void LoadForm()
        {
            Database.SQLConnect.Open();
        }
    }
}
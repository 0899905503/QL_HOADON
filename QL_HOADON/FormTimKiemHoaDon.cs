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
    public partial class FormTimKiemHoaDon : Form
    {
        public FormTimKiemHoaDon()
        {
            InitializeComponent();
        }
        public void SearchHoaDon(object sender, EventArgs e)
        {
            var hoadonID = comboBox1.Text;
            if (hoadonID == null)
            {
                MessageBox.Show($"Hoa don ID la truong bat buoc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string queryString = @"SELECT * FROM HOADON WHERE SOHD = @MaHD";
                    Database.SQLConnect.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Database.SQLConnect);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@MaHD", hoadonID);
                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
                catch (System.Exception)
                {
                    MessageBox.Show($"Có lỗi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
}

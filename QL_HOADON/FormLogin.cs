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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        public void Login(object sender, EventArgs e)
        {
            var username = txtTendangnhap.Text;
            var password = txtPass.Text;

        }
    }
}

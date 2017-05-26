using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employment_center_v2._0
{
    public partial class preadmin : Form
    {
        public preadmin()
        {
            InitializeComponent();
        }

        private void authbtn_Click(object sender, EventArgs e)
        {
            if (passwdbox.Text=="fihure")
            {
                admin admin = new admin();
                admin.Show();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

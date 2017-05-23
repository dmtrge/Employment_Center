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
            //  string t = "t";   
            if (this.passwdbox.Text=="user")
            {
                MessageBox.Show("ss");
            }
           
        }
    }
}

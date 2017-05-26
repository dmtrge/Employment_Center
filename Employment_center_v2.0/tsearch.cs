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
    public partial class tsearch : Form
    {
        public tsearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tsearch tsearch = new tsearch();
            tsearch.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

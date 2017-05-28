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
    public partial class preeditform : Form
    {
        public preeditform()
        {
            InitializeComponent();
        }

        private void vacbtn_Click(object sender, EventArgs e)
        {
            vacantion_edit vacantion_edit = new vacantion_edit();
            vacantion_edit.Show();
        }
    }
}

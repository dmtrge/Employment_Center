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
    public partial class aboutvacanciton : Form
    {
        public aboutvacanciton()
        {
            InitializeComponent();
        }

        private void aboutvacanciton_Load(object sender, EventArgs e)
        {
            genform genform = new genform();

            this.idlabel.Text = genform.id;
            this.profilelab.Text = genform.profile;
            this.speclabel.Text = genform.speciality;
            this.complabel.Text = genform.company;
            this.reqlabel.Text = genform.requirements;
            this.sallarylabel.Text = genform.salary;
            this.explabel.Text = genform.exp;
            this.graphlabel.Text = genform.graph;
            this.localionlabel.Text = genform.location;
            this.aboutlabel.Text = genform.about;
            this.datelabel.Text = genform.date;
        }
    }
}

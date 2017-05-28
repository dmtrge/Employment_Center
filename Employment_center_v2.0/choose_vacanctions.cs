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
    public partial class choose_vacanctions : Form
    {
        public choose_vacanctions()
        {
            InitializeComponent();
        }

        private void choose_vacansion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.vacantiondb". При необходимости она может быть перемещена или удалена.
            this.vacantiondbTableAdapter.Fill(this.jobDatabaseDataSet.vacantiondb);

        }

        private void choose_vacansion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
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
            this.datelabel.Text
        }
    }
}

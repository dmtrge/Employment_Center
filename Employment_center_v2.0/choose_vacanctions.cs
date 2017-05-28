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
        public static string id = null;
        public static string profile = null;
        public static string speciality = null;
        public static string company = null;
        public static string requirements = null;
        public static string salary = null;
        public static string exp = null;
        public static string graph = null;
        public static string location = null;
        public static string about = null;
        public static string date = null;
        public static string actual = null;

        public choose_vacanctions()
        {

            InitializeComponent();
        }

        private void choose_vacansion_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.vacantiondb". При необходимости она может быть перемещена или удалена.
            this.vacantiondbTableAdapter.Fill(this.jobDatabaseDataSet.vacantiondb);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.vacantiondb". При необходимости она может быть перемещена или удалена.
            this.vacantiondbTableAdapter.Fill(this.jobDatabaseDataSet.vacantiondb);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.vacantiondb". При необходимости она может быть перемещена или удалена.
            this.vacantiondbTableAdapter.Fill(this.jobDatabaseDataSet.vacantiondb);

        }

        private void choose_vacansion_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            profile = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            speciality = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            company = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            requirements = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            salary = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            exp = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            graph = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            location = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            about = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            date = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);

            MessageBox.Show("Уверены, что хотите редактировать эту запись? ");
            vacantion_edit vacantion_edit = new vacantion_edit();
            vacantion_edit.Show();
        }
    }
}

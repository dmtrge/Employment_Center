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
    public partial class arrayusers : Form
    {
        public static string id = null;
        public static string firstname = null;
        public static string lastname = null;
        public static string surname = null;
        public static string telephone = null;
        public static string IDpas = null;
        public static string education = null;
        public static string adress = null;
        public static string vacantion = null;
        public static string note = null;
        public static string datereg = null;

        public arrayusers()
        {
            InitializeComponent();
        }

        private void arrayusers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobDatabaseDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.jobDatabaseDataSet.users);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            firstname = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            lastname = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            surname = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            telephone = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            IDpas = Convert.ToString(dataGridView1.CurrentRow.Cells[5]);
            education = Convert.ToString(dataGridView1.CurrentRow.Cells[6]);
            adress = Convert.ToString(dataGridView1.CurrentRow.Cells[7]);
            vacantion = Convert.ToString(dataGridView1.CurrentRow.Cells[8]);
            note = Convert.ToString(dataGridView1.CurrentRow.Cells[9]);
            datereg = Convert.ToString(dataGridView1.CurrentRow.Cells[10]);
        }
    }
}

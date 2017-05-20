using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employment_center_v2._0
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            headband headband = new headband();
            this.Close();
            headband.Show();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\projects\CZ\Employment_center_v2.0\Employment_center_v2.0\JobDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (var myConnection = new SqlConnection(сonnectionString))
            {
                myConnection.Open(); 
                var sqlCommand = new SqlCommand("INSERT INTO vacantiondb (profile, speciality, company, requirements,salary, exp, graph, location,date ) VALUES(@profile, @speciality, @company, @requirements, @salary, @exp, @graph, @location, @date)",myConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@profile", profiletbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@speciality",specialitytbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@company",companytbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@requirements",requirementstbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@salary",salarytbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@exp",exptbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@graph",graphtbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@location",locationtbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@date", createcal.Value));
                MessageBox.Show("Запись создана успешнно");
                this.Close();

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                finally
                {
                    myConnection.Close();
                }
            }
         }

        private void adduserbtn_Click(object sender, EventArgs e)
        {
            adduser adduser = new adduser();
            adduser.Show();

        }
    }
}

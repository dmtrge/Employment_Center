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
    public partial class vacantion_edit : Form
    {
        public vacantion_edit()
        {
            InitializeComponent();
        }

        private void vacantion_edit_Load(object sender, EventArgs e)
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

        private void editbtn_Click(object sender, EventArgs e)
        {

            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\projects\CZ\Employment_center_v2.0\Employment_center_v2.0\JobDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (var myConnection = new SqlConnection(сonnectionString))
            {
                myConnection.Open();
                var sqlCommand = new SqlCommand("INSERT INTO vacantiondb (id, profile, speciality, company, requirements,salary, exp, graph, location,date ) VALUES(@id, @profile, @speciality, @company, @requirements, @salary, @exp, @graph, @location, @date)", myConnection);

               
                sqlCommand.Parameters.Add(new SqlParameter("@id", idbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@profile", profilebox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@speciality", specialitybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@company", companybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@requirements", requirementsbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@salary", sallarybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@exp", expbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@about", aboutbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@date", datebox.Value));
                sqlCommand.Parameters.Add(new SqlParameter("@actual", actualbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@location", locationbox.Text));
            }
        }
    }
}


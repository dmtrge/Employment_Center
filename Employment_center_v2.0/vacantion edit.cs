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
            choose_vacanctions choose_vacanctions = new choose_vacanctions();
            this.idlabel.Text = choose_vacanctions.id;
            this.profilelab.Text = choose_vacanctions.profile;
            this.speclabel.Text = choose_vacanctions.speciality;
            this.complabel.Text = choose_vacanctions.company;
            this.reqlabel.Text = choose_vacanctions.requirements;
            this.sallarylabel.Text = choose_vacanctions.salary;
            this.explabel.Text = choose_vacanctions.exp;
            this.graphlabel.Text = choose_vacanctions.graph;
            this.localionlabel.Text = choose_vacanctions.location;
            this.aboutlabel.Text = choose_vacanctions.about;
            this.datelabel.Text = choose_vacanctions.date;
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


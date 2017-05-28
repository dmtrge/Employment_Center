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
    public partial class aboutclients : Form
    {
        public aboutclients()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutclients_Load(object sender, EventArgs e)
        {
            arrayusers arrayusers = new arrayusers();
            this.id.Text = arrayusers.id;
            this.firstname.Text = arrayusers.firstname;
            this.lastname.Text = arrayusers.lastname;
            this.surname.Text = arrayusers.surname;
            this.telephone.Text = arrayusers.telephone;
            this.IDpas.Text = arrayusers.IDpas;
            this.education.Text = arrayusers.education;
            this.address.Text = arrayusers.adress;
            this.vacantion.Text = arrayusers.vacantion;
            this.note.Text = arrayusers.note;
            this.datereg.Text = arrayusers.datereg;
        }
    }
}

﻿using System;
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
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\projects\CZ\Employment_center_v2.0\Employment_center_v2.0\JobDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            using (var myConnection = new SqlConnection(сonnectionString))
            {
                myConnection.Open();
                var sqlCommand = new SqlCommand("INSERT INTO users firstname, lastname,surname,telephone,IDpas , education, address, vacantion, note,datereg) VALUES(@firstname, @lastname,@surname,@telephone,@IDpas , @education, @address, @vacantion, @note,@datereg)", myConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@firstname", ));
               
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
    }
    }
}

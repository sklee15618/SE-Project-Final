using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Web;
using System.Net.Mail;
namespace FinalSprintProject
{
    public partial class deleteEvent : Form
    {
        public deleteEvent()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            {
                string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
                string Query = "SELECT* FROM sample_table.event;" ;
                MySqlConnection conDatabase = new MySqlConnection(constring);
                //MySqlCommand cmdDatabase = new MySqlCommand("SELECT ID, firstname, lastname, email, warningSuspension AS 'Warning Suspension', suspended FROM sample_table.personal_info_table ;", conDatabase);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;
                try
                {
                    conDatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();

                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("name");
                        comboBox1.Items.Add(sName);
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

            //c.PaperlessWaiver(this.PrintName_txt.Text, this.SignName_txt.Text, this.MemType_txt.Text, this.Gender_txt.Text, this.dateWaiver.Text, this.TimeArr_txt.Text, this.TimeLeft_txt.Text);

            
            // this.Hide();
            // Form1 f1 = new Form1();
            //f1.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendar f2 = new calendar();
            f2.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            string Query = "SELECT* FROM sample_table.event where name='"+comboBox1.Text +"' ; ";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            //MySqlCommand cmdDatabase = new MySqlCommand("SELECT ID, firstname, lastname, email, warningSuspension AS 'Warning Suspension', suspended FROM sample_table.personal_info_table ;", conDatabase);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString("name");
                    comboBox1.Items.Add(sName);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {

            {
                string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
                string Query = "delete from sample_table.event where name = '"+ this.comboBox1.Text +"' ;"; 
                MySqlConnection conDatabase = new MySqlConnection(constring);
                //MySqlCommand cmdDatabase = new MySqlCommand("SELECT ID, firstname, lastname, email, warningSuspension AS 'Warning Suspension', suspended FROM sample_table.personal_info_table ;", conDatabase);
                MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
                MySqlDataReader myReader;
                try
                {
                    conDatabase.Open();
                    myReader = cmdDatabase.ExecuteReader();

                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("name");
                        comboBox1.Items.Add(sName);
                    }
                    MessageBox.Show("Event deleted");
                    this.Hide();
                    calendar f3 = new calendar();
                    f3.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}

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


namespace FinalSprintProject
{
    public partial class calendarNew : Form
    {
        public calendarNew()
        {
            InitializeComponent();
            load_table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        void load_table()
        {

            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT name, date, memo FROM sample_table.event ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase =new MySqlCommand("SELECT name, date, memo FROM sample_table.event ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.AddEvent(this.date.Text, this.name.Text, this.memo.Text);

            //c.PaperlessWaiver(this.PrintName_txt.Text, this.SignName_txt.Text, this.MemType_txt.Text, this.Gender_txt.Text, this.dateWaiver.Text, this.TimeArr_txt.Text, this.TimeLeft_txt.Text);

            MessageBox.Show("Event saved");
            
            
            
        }

        private void eventsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.eventsDataGrid.Rows[e.RowIndex];
                name.Text = row.Cells["name"].Value.ToString();
                date.Text = row.Cells["date"].Value.ToString();
                memo.Text = row.Cells["memo"].Value.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            string Query = "delete from sample_table.event where name = '" + this.name.Text + "' ;";
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
                    
                }
                MessageBox.Show("Event deleted");
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void searchEventName_TextChanged(object sender, EventArgs e)
        {
           // DataView DV = new DataView(dbdataset);
           // DV.RowFilter = "Convert(ID, 'System.String') like '%" + SearchPatronID.Text + "%'";
          //  PatronProfileView.DataSource = DV;
        }

        private void EventsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

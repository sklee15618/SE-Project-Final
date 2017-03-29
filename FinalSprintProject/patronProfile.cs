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
    public partial class patronProfile : Form
    {
        public patronProfile()
        {
            InitializeComponent();
        }

        DataTable dbdataset;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReturntoMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();
        }

        private void inputIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadtable_txt_Click(object sender, EventArgs e)
        {

            string constring = "datasource=localhost;port=3306;username=root;password=3a1w";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT * FROM sample_table.personal_info_table ;", conDatabase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                PatronProfileView.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatronProfileView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   
     
        //search id patron
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("idpatron LIKE '%{0}%'", textBox1.Text);
            PatronProfileView.DataSource = DV;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            c.PatronProfileInsert(this.ID_txt.Text, this.password_txt.Text, this.Firstname_txt.Text, this.Lastname_txt.Text, this.dateTimePicker1.Text, this.Address_txt.Text, this.City_txt.Text, this.State_txt.Text, this.ZipCode_txt.Text, this.Phone_txt.Text, this.email.Text);
            MessageBox.Show("Information saved");
           // this.Hide();
           // Form1 f1 = new Form1();
           // f1.ShowDialog();
        }
    }
}

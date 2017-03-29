using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSprintProject
{
    public partial class newEmployee : Form
    {
        public newEmployee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReturntoMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void FirstName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.Insert_Employee( this.ID_txt.Text, this.password_txt.Text, this.FirstName_txt.Text, this.LastName_txt.Text, this.dateTimePicker1.Text,
                 this.Address_txt.Text, this.City_txt.Text, this.State_txt.Text, 
                 this.ZipCode_txt.Text, this.Phone_txt.Text, this.email.Text, this.Position_Combobox.Text
                 );
            MessageBox.Show("Information saved");
           // this.Hide();
          //  Form1 f1 = new Form1();
          //  f1.ShowDialog();
        }

        private void Phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ID_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();
            c.Inventory(this.idTxt.Text, this.equipTxt.Text, 0);
            MessageBox.Show("Checked out!");
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

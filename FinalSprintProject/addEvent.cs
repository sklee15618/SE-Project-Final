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
    public partial class addEvent : Form
    {

        public addEvent()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            calendar f1 = new calendar();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.AddEvent(this.date.Text, this.name.Text, this.memo.Text);

            //c.PaperlessWaiver(this.PrintName_txt.Text, this.SignName_txt.Text, this.MemType_txt.Text, this.Gender_txt.Text, this.dateWaiver.Text, this.TimeArr_txt.Text, this.TimeLeft_txt.Text);

            MessageBox.Show("Event saved");
            this.Hide();
            calendar f3 = new calendar();
            f3.ShowDialog();

            // this.Hide();
            // Form1 f1 = new Form1();
            //f1.ShowDialog();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

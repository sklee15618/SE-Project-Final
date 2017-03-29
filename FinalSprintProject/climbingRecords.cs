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
    public partial class climbingRecords : Form
    {
        public climbingRecords()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb_sec.Text = "00";
            lb_min.Text = "00";
            lb_hour.Text = "00";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(lb_sec.Text == "59")
            {
                if(lb_min.Text == "59")
                    {
                    lb_sec.Text = "00";
                    lb_min.Text = "00";
                    lb_hour.Text = (Convert.ToInt32(lb_hour.Text) + 1).ToString();

                }
                else
                {
                    lb_sec.Text = "00";
                    lb_min.Text = (Convert.ToInt32(lb_min.Text) + 1).ToString();
                }

            }
            else
            {
                lb_sec.Text = (Convert.ToInt32(lb_sec.Text) + 1).ToString();
            }

        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
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
    public partial class paperlessWaiver : Form
    {
        public paperlessWaiver()
        {
            InitializeComponent();
        }

        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu f1 = new mainMenu();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PaperlessWaiverLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DBConnect c = new DBConnect();

            c.PaperlessWaiver(this.PrintName_txt.Text, this.SignName_txt.Text, this.MemType_txt.Text, this.Gender_txt.Text, this.dateWaiver.Text, this.currentTime.Text, this.TimeLeft_txt.Text);
            
            //c.PaperlessWaiver(this.PrintName_txt.Text, this.SignName_txt.Text, this.MemType_txt.Text, this.Gender_txt.Text, this.dateWaiver.Text, this.TimeArr_txt.Text, this.TimeLeft_txt.Text);

            MessageBox.Show("Information saved");
           // this.Hide();
           // Form1 f1 = new Form1();
            //f1.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void paperlessWaiver_Load(object sender, EventArgs e)
        {
            //currentDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            currentTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

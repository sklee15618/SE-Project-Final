﻿namespace FinalSprintProject
{
    partial class employeeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TrackingButton = new System.Windows.Forms.Button();
            this.SuspensionButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.Location = new System.Drawing.Point(59, 54);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(549, 36);
            this.MenuTitle.TabIndex = 9;
            this.MenuTitle.Text = "SDSU Wellness Center Climbing Wall";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(137, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 57);
            this.button1.TabIndex = 11;
            this.button1.Text = "Waiver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrackingButton
            // 
            this.TrackingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackingButton.Location = new System.Drawing.Point(315, 152);
            this.TrackingButton.Name = "TrackingButton";
            this.TrackingButton.Size = new System.Drawing.Size(136, 57);
            this.TrackingButton.TabIndex = 12;
            this.TrackingButton.Text = "Tracking";
            this.TrackingButton.UseVisualStyleBackColor = true;
            this.TrackingButton.Click += new System.EventHandler(this.TrackingButton_Click);
            // 
            // SuspensionButton
            // 
            this.SuspensionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuspensionButton.Location = new System.Drawing.Point(137, 237);
            this.SuspensionButton.Name = "SuspensionButton";
            this.SuspensionButton.Size = new System.Drawing.Size(136, 57);
            this.SuspensionButton.TabIndex = 13;
            this.SuspensionButton.Text = "Suspension";
            this.SuspensionButton.UseVisualStyleBackColor = true;
            this.SuspensionButton.Click += new System.EventHandler(this.SuspensionButton_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarButton.Location = new System.Drawing.Point(315, 237);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(136, 57);
            this.CalendarButton.TabIndex = 14;
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 459);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.SuspensionButton);
            this.Controls.Add(this.TrackingButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MenuTitle);
            this.Name = "Form13";
            this.Text = "Form13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button TrackingButton;
        private System.Windows.Forms.Button SuspensionButton;
        private System.Windows.Forms.Button CalendarButton;
    }
}
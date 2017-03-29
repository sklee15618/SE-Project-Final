namespace FinalSprintProject
{
    partial class patronProfile
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
            this.PatronProfileLabel = new System.Windows.Forms.Label();
            this.inputIDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ReturntoMainMenuButton = new System.Windows.Forms.Button();
            this.PatronProfileView = new System.Windows.Forms.DataGridView();
            this.loadtable_txt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ZipcodeLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.Label();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.Firstname_txt = new System.Windows.Forms.TextBox();
            this.Lastname_txt = new System.Windows.Forms.TextBox();
            this.Address_txt = new System.Windows.Forms.TextBox();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.email = new System.Windows.Forms.TextBox();
            this.City_txt = new System.Windows.Forms.TextBox();
            this.State_txt = new System.Windows.Forms.TextBox();
            this.ZipCode_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PatronProfileView)).BeginInit();
            this.SuspendLayout();
            // 
            // PatronProfileLabel
            // 
            this.PatronProfileLabel.AutoSize = true;
            this.PatronProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatronProfileLabel.Location = new System.Drawing.Point(25, 23);
            this.PatronProfileLabel.Name = "PatronProfileLabel";
            this.PatronProfileLabel.Size = new System.Drawing.Size(173, 29);
            this.PatronProfileLabel.TabIndex = 0;
            this.PatronProfileLabel.Text = "Patron Profile";
            // 
            // inputIDLabel
            // 
            this.inputIDLabel.AutoSize = true;
            this.inputIDLabel.Location = new System.Drawing.Point(669, 171);
            this.inputIDLabel.Name = "inputIDLabel";
            this.inputIDLabel.Size = new System.Drawing.Size(70, 17);
            this.inputIDLabel.TabIndex = 1;
            this.inputIDLabel.Text = "Search ID";
            this.inputIDLabel.Click += new System.EventHandler(this.inputIDLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(757, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ReturntoMainMenuButton
            // 
            this.ReturntoMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturntoMainMenuButton.Location = new System.Drawing.Point(392, 645);
            this.ReturntoMainMenuButton.Name = "ReturntoMainMenuButton";
            this.ReturntoMainMenuButton.Size = new System.Drawing.Size(343, 53);
            this.ReturntoMainMenuButton.TabIndex = 5;
            this.ReturntoMainMenuButton.Text = "Return to Main Menu";
            this.ReturntoMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturntoMainMenuButton.Click += new System.EventHandler(this.ReturntoMainMenuButton_Click);
            // 
            // PatronProfileView
            // 
            this.PatronProfileView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatronProfileView.Location = new System.Drawing.Point(672, 203);
            this.PatronProfileView.Name = "PatronProfileView";
            this.PatronProfileView.RowTemplate.Height = 24;
            this.PatronProfileView.Size = new System.Drawing.Size(786, 290);
            this.PatronProfileView.TabIndex = 6;
            this.PatronProfileView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatronProfileView_CellContentClick);
            // 
            // loadtable_txt
            // 
            this.loadtable_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadtable_txt.Location = new System.Drawing.Point(891, 514);
            this.loadtable_txt.Name = "loadtable_txt";
            this.loadtable_txt.Size = new System.Drawing.Size(171, 53);
            this.loadtable_txt.TabIndex = 7;
            this.loadtable_txt.Text = "Load Table";
            this.loadtable_txt.UseVisualStyleBackColor = true;
            this.loadtable_txt.Click += new System.EventHandler(this.loadtable_txt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(248, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 53);
            this.button1.TabIndex = 29;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "password";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameLabel.Location = new System.Drawing.Point(46, 171);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(113, 25);
            this.FirstnameLabel.TabIndex = 33;
            this.FirstnameLabel.Text = "First name";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameLabel.Location = new System.Drawing.Point(46, 203);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(112, 25);
            this.LastnameLabel.TabIndex = 34;
            this.LastnameLabel.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Birth date";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(47, 264);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(87, 24);
            this.AddressLabel.TabIndex = 36;
            this.AddressLabel.Text = "Address";
            // 
            // ZipcodeLabel
            // 
            this.ZipcodeLabel.AutoSize = true;
            this.ZipcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipcodeLabel.Location = new System.Drawing.Point(46, 301);
            this.ZipcodeLabel.Name = "ZipcodeLabel";
            this.ZipcodeLabel.Size = new System.Drawing.Size(155, 25);
            this.ZipcodeLabel.TabIndex = 37;
            this.ZipcodeLabel.Text = "City, State, Zip";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.Location = new System.Drawing.Point(46, 336);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(74, 25);
            this.PhoneLabel.TabIndex = 38;
            this.PhoneLabel.Text = "Phone";
            // 
            // email_txt
            // 
            this.email_txt.AutoSize = true;
            this.email_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(46, 374);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(73, 25);
            this.email_txt.TabIndex = 39;
            this.email_txt.Text = "E-mail";
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(248, 100);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(297, 22);
            this.ID_txt.TabIndex = 40;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(248, 140);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(297, 22);
            this.password_txt.TabIndex = 41;
            // 
            // Firstname_txt
            // 
            this.Firstname_txt.Location = new System.Drawing.Point(248, 174);
            this.Firstname_txt.Name = "Firstname_txt";
            this.Firstname_txt.Size = new System.Drawing.Size(297, 22);
            this.Firstname_txt.TabIndex = 42;
            // 
            // Lastname_txt
            // 
            this.Lastname_txt.Location = new System.Drawing.Point(248, 207);
            this.Lastname_txt.Name = "Lastname_txt";
            this.Lastname_txt.Size = new System.Drawing.Size(297, 22);
            this.Lastname_txt.TabIndex = 43;
            // 
            // Address_txt
            // 
            this.Address_txt.Location = new System.Drawing.Point(248, 264);
            this.Address_txt.Name = "Address_txt";
            this.Address_txt.Size = new System.Drawing.Size(297, 22);
            this.Address_txt.TabIndex = 44;
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(248, 340);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(297, 22);
            this.Phone_txt.TabIndex = 47;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 22);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(248, 378);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(297, 22);
            this.email.TabIndex = 49;
            // 
            // City_txt
            // 
            this.City_txt.Location = new System.Drawing.Point(248, 301);
            this.City_txt.Name = "City_txt";
            this.City_txt.Size = new System.Drawing.Size(110, 22);
            this.City_txt.TabIndex = 50;
            // 
            // State_txt
            // 
            this.State_txt.Location = new System.Drawing.Point(364, 301);
            this.State_txt.Name = "State_txt";
            this.State_txt.Size = new System.Drawing.Size(51, 22);
            this.State_txt.TabIndex = 51;
            // 
            // ZipCode_txt
            // 
            this.ZipCode_txt.Location = new System.Drawing.Point(421, 301);
            this.ZipCode_txt.Name = "ZipCode_txt";
            this.ZipCode_txt.Size = new System.Drawing.Size(100, 22);
            this.ZipCode_txt.TabIndex = 52;
            // 
            // patronProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 733);
            this.Controls.Add(this.ZipCode_txt);
            this.Controls.Add(this.State_txt);
            this.Controls.Add(this.City_txt);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Phone_txt);
            this.Controls.Add(this.Address_txt);
            this.Controls.Add(this.Lastname_txt);
            this.Controls.Add(this.Firstname_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.email_txt);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.ZipcodeLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastnameLabel);
            this.Controls.Add(this.FirstnameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loadtable_txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.inputIDLabel);
            this.Controls.Add(this.PatronProfileView);
            this.Controls.Add(this.ReturntoMainMenuButton);
            this.Controls.Add(this.PatronProfileLabel);
            this.Name = "patronProfile";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.loadtable_txt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PatronProfileView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatronProfileLabel;
        private System.Windows.Forms.Label inputIDLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ReturntoMainMenuButton;
        private System.Windows.Forms.DataGridView PatronProfileView;
        private System.Windows.Forms.Button loadtable_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label ZipcodeLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label email_txt;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox Firstname_txt;
        private System.Windows.Forms.TextBox Lastname_txt;
        private System.Windows.Forms.TextBox Address_txt;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox City_txt;
        private System.Windows.Forms.TextBox State_txt;
        private System.Windows.Forms.TextBox ZipCode_txt;
    }
}
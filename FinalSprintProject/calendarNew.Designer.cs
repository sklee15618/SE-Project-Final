namespace FinalSprintProject
{
    partial class calendarNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataTxt = new System.Windows.Forms.Label();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.eventsDataGrid = new System.Windows.Forms.DataGridView();
            this.addEvents = new System.Windows.Forms.Label();
            this.eventTxt = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.editButton = new System.Windows.Forms.Button();
            this.searchEvenDate = new System.Windows.Forms.Label();
            this.searchEventDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchEventName = new System.Windows.Forms.TextBox();
            this.addEventName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calendar";
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventsLabel.Location = new System.Drawing.Point(251, 26);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(145, 24);
            this.EventsLabel.TabIndex = 1;
            this.EventsLabel.Text = "Search Events";
            this.EventsLabel.Click += new System.EventHandler(this.EventsLabel_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(4, 130);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(459, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return to Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataTxt
            // 
            this.dataTxt.AutoSize = true;
            this.dataTxt.Location = new System.Drawing.Point(697, 88);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(65, 12);
            this.dataTxt.TabIndex = 9;
            this.dataTxt.Text = "Event Date";
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(807, 117);
            this.memo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(226, 131);
            this.memo.TabIndex = 10;
            this.memo.Text = "";
            // 
            // eventsDataGrid
            // 
            this.eventsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGrid.Location = new System.Drawing.Point(256, 130);
            this.eventsDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventsDataGrid.Name = "eventsDataGrid";
            this.eventsDataGrid.RowTemplate.Height = 24;
            this.eventsDataGrid.Size = new System.Drawing.Size(418, 155);
            this.eventsDataGrid.TabIndex = 11;
            this.eventsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventsDataGrid_CellContentClick);
            // 
            // addEvents
            // 
            this.addEvents.AutoSize = true;
            this.addEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEvents.Location = new System.Drawing.Point(696, 26);
            this.addEvents.Name = "addEvents";
            this.addEvents.Size = new System.Drawing.Size(189, 24);
            this.addEvents.TabIndex = 16;
            this.addEvents.Text = "Add/Update Events";
            // 
            // eventTxt
            // 
            this.eventTxt.AutoSize = true;
            this.eventTxt.Location = new System.Drawing.Point(697, 119);
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(103, 12);
            this.eventTxt.TabIndex = 18;
            this.eventTxt.Text = "Event Description";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(789, 261);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 24);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd";
            this.date.Location = new System.Drawing.Point(807, 83);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(218, 21);
            this.date.TabIndex = 20;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(934, 261);
            this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(113, 24);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchEvenDate
            // 
            this.searchEvenDate.AutoSize = true;
            this.searchEvenDate.Location = new System.Drawing.Point(253, 88);
            this.searchEvenDate.Name = "searchEvenDate";
            this.searchEvenDate.Size = new System.Drawing.Size(109, 12);
            this.searchEvenDate.TabIndex = 23;
            this.searchEvenDate.Text = "Search Event Date";
            // 
            // searchEventDate
            // 
            this.searchEventDate.Location = new System.Drawing.Point(388, 85);
            this.searchEventDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchEventDate.Name = "searchEventDate";
            this.searchEventDate.Size = new System.Drawing.Size(147, 21);
            this.searchEventDate.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 12);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search Event Name";
            // 
            // searchEventName
            // 
            this.searchEventName.Location = new System.Drawing.Point(388, 58);
            this.searchEventName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchEventName.Name = "searchEventName";
            this.searchEventName.Size = new System.Drawing.Size(147, 21);
            this.searchEventName.TabIndex = 27;
            this.searchEventName.TextChanged += new System.EventHandler(this.searchEventName_TextChanged);
            // 
            // addEventName
            // 
            this.addEventName.AutoSize = true;
            this.addEventName.Location = new System.Drawing.Point(697, 62);
            this.addEventName.Name = "addEventName";
            this.addEventName.Size = new System.Drawing.Size(74, 12);
            this.addEventName.TabIndex = 28;
            this.addEventName.Text = "Event Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(807, 57);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(218, 21);
            this.name.TabIndex = 29;
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(274, 301);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(122, 46);
            this.loadDataBtn.TabIndex = 30;
            this.loadDataBtn.Text = "Refresh results";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(789, 313);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 23);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // calendarNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 393);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.loadDataBtn);
            this.Controls.Add(this.name);
            this.Controls.Add(this.addEventName);
            this.Controls.Add(this.searchEventName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchEventDate);
            this.Controls.Add(this.searchEvenDate);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.date);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.addEvents);
            this.Controls.Add(this.eventsDataGrid);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.EventsLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "calendarNew";
            this.Text = "Form9";
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dataTxt;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.DataGridView eventsDataGrid;
        private System.Windows.Forms.Label addEvents;
        private System.Windows.Forms.Label eventTxt;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label searchEvenDate;
        private System.Windows.Forms.TextBox searchEventDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchEventName;
        private System.Windows.Forms.Label addEventName;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}
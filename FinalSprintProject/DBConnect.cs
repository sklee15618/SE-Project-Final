using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace FinalSprintProject
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "sample_table";
            uid = "root";
            password = "3a1w";
            string newConnectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(newConnectionString);
        }

        internal void PatronProfile(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, string text9, string text10, object patronProfileView)
        {
            throw new NotImplementedException();
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert employee statement
        public void Insert_Employee(string ID_txt, string password_txt, string FirstName_txt, string LastName_txt, 
            string dateTimePicker1, 
            string Address, string City_txt, string State_txt,
            string ZipCode_txt, string Phone_txt, string email, string Position_Combobox)
        {

            string queryemp = "INSERT INTO personal_info_table (id, firstname,lastname,birthday,address,city,state,zip,phone,email, isPatron, isEmployee, isManager, isAdmin, warningSuspension, suspended) VALUES ('" + ID_txt + "','" + FirstName_txt + "','" + LastName_txt + "','" + dateTimePicker1 + "', '" + Address + "', '" + City_txt + "', '" + State_txt + "', '" + ZipCode_txt + "', '" + Phone_txt + "', '"+ email + "', '0', '1', '0', '0', '0', '0')";
            string querymanager = "INSERT INTO personal_info_table (id, firstname,lastname,birthday,address,city,state,zip,phone, email, isPatron, isEmployee, isManager, isAdmin, warningSuspension, suspended) VALUES ('" + ID_txt + "', '" + FirstName_txt + "','" + LastName_txt + "','" + dateTimePicker1 + "', '" + Address + "', '" + City_txt + "', '" + State_txt + "', '" + ZipCode_txt + "', '" + Phone_txt + "', '" + email + "', '0', '0', '1', '0', '0', '0')";
            string queryadmin = "INSERT INTO personal_info_table (id, firstname,lastname,birthday,address,city,state,zip,phone, email, isPatron, isEmployee, isManager, isAdmin, warningSuspension, suspended) VALUES ('" + ID_txt + "', '" + FirstName_txt + "','" + LastName_txt + "','" + dateTimePicker1 + "', '" + Address + "', '" + City_txt + "', '" + State_txt + "', '" + ZipCode_txt + "', '" + Phone_txt + "', '" + email + "', '0', '0', '0', '1', '0', '0')";
           // string query = "INSERT INTO personal_info_table (id, firstname,lastname,birthday,address,city,state,zip,phone,position) VALUES ('" + ID_txt + "', '" + FirstName_txt + "','" + LastName_txt + "','" + dateTimePicker1 +"', '" + Address + "', '" + City_txt + "', '" + State_txt + "', '" + ZipCode_txt + "', '" + Phone_txt + "','"+ Position_Combobox +"')";

            //VALUES()

            //open connection
            if (this.OpenConnection() == true)
            {
                if (Position_Combobox == "Employee")
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(queryemp, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }

                else if(Position_Combobox == "Manager")
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(queryemp, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }

                else if(Position_Combobox == "Administrator")
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(queryadmin, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }
               
            }
        }


        //updating the suspension
        public void UpdateSuspension(bool suspend, string SearchPatronID)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            string query = "UPDATE personal_info_table SET suspended = "+suspend+" where ID = '" + SearchPatronID + "' ";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        // updating the warning suspenstion
        public void UpdateWarningSuspension(bool warningSuspension, string SearchPatronID)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";
            string query = "UPDATE personal_info_table SET warningSuspension = " + warningSuspension + " where ID = '" + SearchPatronID + "' ";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        // adding event statements
            public void AddEvent(string date, string name, string memo)
        {
            string command = "INSERT INTO event (name,date,memo) VALUES('" + name + "','" + date + "','" + memo + "')";
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(command, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        /*
        public void showEvent(string name)
        {
            string queryEvent = "SELECT * FROM sample_table.event WHERE name = " + name;
            MySqlCommand cmd1 = new MySqlCommand(queryEvent, connection);
            MySqlDataReader myReader = cmd1.ExecuteReader();

            while (myReader.Read()) // Verifies if the user exists in the database
            {
                string sName = myReader.GetString("name");
                comboBox1.Items.Add(sName);
            }

            //close Data Reader
            myReader.Close();

        }
        */

        //Paperless Waiver statement
        public void PaperlessWaiver(string PrintName_txt, string SignName_txt, string MemType_txt, string Gender_txt, string currentTime, string TimeArr_txt, string TimeLeft_txt)

        //public void PaperlessWaiver(string PrintName_txt, string SignName_txt, string MemType_txt, string Gender_txt, string dateWaiver, string TimeArr_txt, string TimeLeft_txt)
        {

            //string command = "INSERT INTO waiver_table (printname,signname,membertype,gender,waiverdate,timearr,timeleft) VALUES ('" + PrintName_txt + "','" + SignName_txt + "','" + MemType_txt + "','" + Gender_txt + "', '" + TestDate_txt + "' , '" + TimeArr_txt + "','" + TimeLeft_txt + "')";

            string command = "INSERT INTO waiver_table (printname,signname,membertype,gender,waiverdate,timearr,timeleft) VALUES ('"+ PrintName_txt + "','"+ SignName_txt + "','"+ MemType_txt + "','"+ Gender_txt + "', '" + currentTime + "' , '"+ TimeArr_txt + "','"+ TimeLeft_txt + "')";

            //VALUES()

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(command, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        // login statement
        public int Login(string id, string password)
        {
            string query1 = "SELECT * FROM sample_table.personal_info_table WHERE ID = " + id + " AND password = " + password + " AND isAdmin = '1' ";
            string query2 = "SELECT * FROM sample_table.personal_info_table WHERE ID = " + id + " AND password = " + password + " AND isManager = '1' ";
            string query3 = "SELECT * FROM sample_table.personal_info_table WHERE ID = " + id + " AND password = " + password + " AND isEmployee = '1' ";
            string query4 = "SELECT * FROM sample_table.personal_info_table WHERE ID = " + id + " AND password = " + password + " AND isPatron = '1' ";

            if (this.OpenConnection())
            {
                //----------------------------------------------------------------------------------//
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                MySqlDataReader dataReader1 = cmd1.ExecuteReader();
                if (dataReader1.Read()) // Verifies if the user exists in the database
                {
                    return 1;
                }
               
                //close Data Reader
                dataReader1.Close();

                //----------------------------------------------------------------------------------//
                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                MySqlDataReader dataReader2 = cmd2.ExecuteReader();
                if (dataReader2.Read()) // Verifies if the user exists in the database
                {
                    return 2;
                }
                //close Data Reader
                dataReader2.Close();

                //----------------------------------------------------------------------------------//
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                MySqlDataReader dataReader3 = cmd3.ExecuteReader();
                if (dataReader3.Read()) // Verifies if the user exists in the database
                {
                    return 3;
                }
                //close Data Reader
                dataReader3.Close();

                //----------------------------------------------------------------------------------//
                MySqlCommand cmd4 = new MySqlCommand(query4, connection);
                MySqlDataReader dataReader4 = cmd4.ExecuteReader();
                if (dataReader4.Read()) // Verifies if the user exists in the database
                {
                    return 4;
                }
                //close Data Reader
                dataReader4.Close();

                //close Connection
                this.CloseConnection();
            }
            return 0;
        }

        // patron profile
        public void PatronProfile(string ID, string FirstName, string LastName, 
            string Gender, string Age, string PhoneNumber, string Email, string Address,
            string Suspended, string NeedRenewal, DataGrid PatronProfileView)
        {
            string query = "SELECT * FROM sample_table.personal_info_table WHERE idpatron = " + ID + " AND FirstName = " + FirstName + "  AND LastName = " + LastName + " AND Gender = " + Gender + " AND Age = " + Age + "  AND phoneNumber = " + PhoneNumber + "  AND Email = " + Email + "  AND Address = " + Address + "  AND Suspended = " + Suspended + "  AND needRenewal = " + NeedRenewal + "";
            if (this.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
              //  MySqlDataReader dataReader = cmd.Executereader
               /* try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmd;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    PatronProfileView.DataSource = bSource;
                }
                */
                /*
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read()) // Verifies if the user exists in the database
                {
                    return 1;
                }

                //close Data Reader
                dataReader.Close();
                */
                //close Connection
                this.CloseConnection();
            }
            return ;
        }

        //patron insert statement
        public void PatronProfileInsert(string ID_txt, string password_txt, string FirstName_txt, string LastName_txt,
            string dateTimePicker1,
            string Address, string City_txt, string State_txt,
            string ZipCode_txt, string Phone_txt, string email)
        {
            string query = "INSERT INTO personal_info_table (id, firstname,lastname,birthday,address,city,state,zip,phone,email, isPatron, isEmployee, isManager, isAdmin, warningSuspension, suspended) VALUES ('" + ID_txt + "','" + FirstName_txt + "','" + LastName_txt + "','" + dateTimePicker1 + "', '" + Address + "', '" + City_txt + "', '" + State_txt + "', '" + ZipCode_txt + "', '" + Phone_txt + "', '" + email + "', '0', '1', '0', '0', '0', '0')";
            //VALUES()

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(string query)
        {
            //string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            //string query = "DELETE FROM tableinfo WHERE name='John Smith'";

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {
            try
            {
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                StreamWriter file = new StreamWriter(path);


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                Process process = Process.Start(psi);

                string output;
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\MySqlBackup.sql";
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }

}

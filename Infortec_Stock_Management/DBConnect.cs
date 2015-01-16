using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Configuration;
using System.CodeDom.Compiler;
using System.CodeDom;
using Microsoft.Reporting.WinForms;



namespace Infortec_Stock_Management
{
    
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public static int loggedUserID;
        public static int loggedUserLevel;

        AutoCompleteStringCollection namesCollection;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }
       
        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "infortecstock";
            uid = "root";
            password = "";
            string connectionString =ConfigurationManager.ConnectionStrings["Infortec_Stock_Management.Properties.Settings.infortecstockConnectionString"].ConnectionString;
            
          //  MessageBox.Show(connectionString);
          //  connectionString = "SERVER=" + server + ";" + "DATABASE=" +
          //  database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";


            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
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

        //Insert statement
        public void Insert(string query)
        {
            
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
            

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select(string query)
        {

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
                   
                    list[0].Add(dataReader["name"] + "");
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

        //get sql reader
        public MySqlDataReader getSource()
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = null;
            if (this.OpenConnection() == true)
            {
                cmd = new MySqlCommand("select * from item");
                try
                {
                    dr = cmd.ExecuteReader();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                this.CloseConnection();
            }
            return dr;
        }

        public List<string>[] SelectReader(string query)
        {
          //  query = ToLiteral(query);
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
                int count1 = 0;
                while (dataReader.Read())
                {
                    count1 =0;
                    while (dataReader.FieldCount > count1)
                    {

                        list[count1].Add(dataReader[count1] + "");
                        count1++;
                    }
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
        public int GetSingleVal(String query)
        {
            int Count = -1;
           // query = ToLiteral(query);
           
            //Open Connection
            if (this.OpenConnection() == true)
            {
            //Create Mysql Command
            MySqlCommand cmd = new MySqlCommand(query, connection);

            //ExecuteScalar will return one value
            try
            {
                Count = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -2;
            }
        
            //close Connection
            this.CloseConnection();

            return Count;
            }
            else
            {
                return Count;
            }
        }

        public DataTable getTableForCombo(string query)
        {
            DataTable dt = new DataTable();

           
            MySqlDataAdapter adap;
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                try
                {
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                   
                    
                    //close Connection
                    this.CloseConnection();
                    return dt;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    //close Connection
                    this.CloseConnection();
                    return dt;

                }

                

            }
            else
            {
                return dt;
            }
        }

        public DataSet getDS(String query)
        {
            
            DataSet ds = new DataSet();
            MySqlDataAdapter adap = new MySqlDataAdapter(query,connection);
            adap.Fill(ds);
            return ds;
        }


        public AutoCompleteStringCollection getAutoCompleteCollection(String table){

            namesCollection = new AutoCompleteStringCollection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dReader;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select distinct name from "+table+" order by name asc";
            if (this.OpenConnection() == true)
            {
                
                dReader = cmd.ExecuteReader();
                if (dReader.HasRows == true)
                {
                    while (dReader.Read())
                        namesCollection.Add(dReader["name"].ToString());

                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                dReader.Close();
            }
            return namesCollection;

        }

        //public ReportDataSource getReport(String query)
        //{
        //    //DataSet ds = new DataSet();
        //    //MySqlDataAdapter da = new MySqlDataAdapter(query,connection);
        //    //da.Fill(ds, "empds");

        //    //ReportDataSource RDS = new ReportDataSource("empds", ds.Tables[0]);
        //    //return RDS;
        //}

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
        MessageBox.Show("Error , unable to backup! -- "+ex.Message);
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
        MessageBox.Show("Error , unable to Restore! -- "+ex.Message);
    }
        }


        public string ToLiteral(string input)
        {
            String literalVal = ""; int last = 0; int first =0;
            using (var writer = new System.IO.StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    literalVal = writer.ToString();
                    last = literalVal.LastIndexOf('"');
                    first = literalVal.IndexOf('"');
                    
                    if (last == literalVal.Length - 1 && first == 0)
                    {
                        literalVal = literalVal.Remove(0, 1);
                        literalVal = literalVal.Remove(last-1, 1);
                    }

                    return literalVal;
                }
            }
        }

       
    }
}

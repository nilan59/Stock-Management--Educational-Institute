using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Infortec_Stock_Management
{
    public partial class frm_login : Form
    {
        DBConnect dbc = null;
        int passwordTryCount = 0;
       
        public frm_login()
        {
            InitializeComponent();
            dbc = new DBConnect();
            bindUserNameToDb();
            
        }

        public frm_login(int a)
        {
            splashMethod();
        }

      
        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;
            string passWord = txt_passWord.Text;


            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] md5data = md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(passWord));
            string hashedPassword = System.Text.Encoding.ASCII.GetString(md5data);
            hashedPassword = ToLiteral(hashedPassword);

            string query = "SELECT EXISTS (SELECT 1 FROM user WHERE name='" + userName + "' AND password='" + hashedPassword + "')";
            int value = dbc.GetSingleVal(query);
            if (value == 1)
            {
                string query2 = "SELECT id FROM user WHERE name='" + userName + "' AND password='" + hashedPassword + "'";
                int userId = dbc.GetSingleVal(query2);

                string query3 = "SELECT access_level FROM user WHERE name='" + userName + "' AND password='" + hashedPassword + "'";
                int userLevel = dbc.GetSingleVal(query3);

                DBConnect.loggedUserID = userId;
                DBConnect.loggedUserLevel = userLevel;

                parent pr = new parent();
                this.Hide();
                pr.Show();
               
            }
            else
            {
                MessageBox.Show("invalid credentials","Try Again",MessageBoxButtons.OK,MessageBoxIcon.Error);
                passwordTryCount++;
                if (passwordTryCount > 3)
                {
                    MessageBox.Show("Too many passowrd attempts. System is now exiting!");
                    Application.Exit();
                }
            }

        }

        private void splashMethod()
        {

            SplashScreen.ShowSplashScreen();
            Application.DoEvents();
           
            SplashScreen.SetStatus("Initializing the awesomeness ;)");
            System.Threading.Thread.Sleep(900);
            SplashScreen.SetStatus("Starting all the cool stuff");
            System.Threading.Thread.Sleep(240);
            SplashScreen.SetStatus("Trying to connect to the database");
            System.Threading.Thread.Sleep(90);
            SplashScreen.SetStatus("Inspecting for tools");
            System.Threading.Thread.Sleep(1000);
            SplashScreen.SetStatus("Having a beer!!");
            System.Threading.Thread.Sleep(100);
            SplashScreen.SetStatus("Searching for the ideal woman :*");
            System.Threading.Thread.Sleep(500);
            SplashScreen.SetStatus("Now you are", false);
            System.Threading.Thread.Sleep(500);
            SplashScreen.SetStatus("Wait for it..", false);
         
            System.Threading.Thread.Sleep(500);
            SplashScreen.SetStatus("Starting...", false);
            System.Threading.Thread.Sleep(500);
  
            
            SplashScreen.CloseForm();
            Application.Run(new frm_login());
        }

        private byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private void bindUserNameToDb()
        {
            txt_userName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_userName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_userName.AutoCompleteCustomSource = dbc.getAutoCompleteCollection("user");
        }

        private string ToLiteral(string input)
        {
            using (var writer = new System.IO.StringWriter())
            {
                using (var provider = CodeDomProvider.CreateProvider("CSharp"))
                {
                    provider.GenerateCodeFromExpression(new CodePrimitiveExpression(input), writer, null);
                    return writer.ToString();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

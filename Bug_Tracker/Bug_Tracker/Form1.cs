using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Deployment.Application;

namespace Bug_Tracker
{
    
    public partial class darkLogin : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=******");
        public darkLogin()
        {
            InitializeComponent();
        }

        public static void DBOpen(MySqlConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public static void DBClose(MySqlConnection connection)
        {
            connection.Close();
            
        }
           

        public static class Vars
        {
            public static string username;
            public static string password = "";
        }

        public void CheckFields(string username, string password, MySqlConnection connection)
        {
            //DBOpen(connection);
            string userinfo = "SELECT COUNT(1) FROM bugtracker_users.usersinfo WHERE username = @username";
            string userpassword = "SELECT password FROM bugtracker_users.usersinfo WHERE username = @username";
            string itLevel = "SELECT it_level FROM bugtracker_users.usersinfo WHERE username = @username";

            MySqlCommand checkpassword = new MySqlCommand(userpassword, connection);
            MySqlCommand checkinfo = new MySqlCommand(userinfo, connection);
            MySqlCommand checkIT = new MySqlCommand(itLevel, connection);

            checkinfo.Parameters.AddWithValue("@username", Vars.username);
            checkpassword.Parameters.AddWithValue("@username", Vars.username);
            checkIT.Parameters.AddWithValue("@username", Vars.username);

            int rows = Convert.ToInt32(checkinfo.ExecuteScalar());
            string newpassword = Convert.ToString(checkpassword.ExecuteScalar());
            int itNum = Convert.ToInt32(checkIT.ExecuteScalar());

            if(rows == 0)
            {
                MessageBox.Show("No match for username");
            }
            else
            {
                if(newpassword != Vars.password)
                {
                    MessageBox.Show("Password does not match");
                }
                else
                {
                    if(itNum == 0)
                    {
                        DecisionPage();
                    }
                    else
                    {
                        BugListPage();
                    }
                }
            }
            
        }

        public void RegistrationPage()
        {
            this.Hide();
            var r = new darkRegistration();
            r.Show();
        }

        public void DecisionPage()
        {
            this.Hide();
            var rr = new darkDecision();
            rr.Show();
        }

        public void BugListPage()
        {
            this.Hide();
            var bl = new darkList();
            bl.Show();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Vars.username = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            Vars.password = textBox2.Text;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DBOpen(connection);
            CheckFields(Vars.username, Vars.password, connection);
            DBClose(connection);
        }

        private void newUserButton_Click(object sender, EventArgs e)
        {
            RegistrationPage();
        }

        private void darkModeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (darkModeBox.Checked == false)
            {
                this.Hide();
                var lm = new lightLogin();
                lm.Show();
            }
        }

        private void darkLogin_Load(object sender, EventArgs e)
        {
            darkModeBox.Checked = true;
        }
    }
}

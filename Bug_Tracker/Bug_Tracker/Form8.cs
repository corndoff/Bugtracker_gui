using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bug_Tracker
{
    public partial class lightRegistration : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=****");

        public static class Vars
        {
            public static string firstName;
            public static string lastName;
            public static string username;
            public static string password;
            public static string userEmail;
            public static string userDepartment;
            public static int levelofAcess;
        }

        public bool CheckRequirements()
        {
            if (fNameBox.Text == "" || lNameText.Text == "" || usernameText.Text == "" || passwordText.Text == "" || userEmailText.Text == "" ||
                userDepartmentText.Text == "" || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void InitializeDropDown()
        {
            comboBox1.Items.Add("Accounting");
            comboBox1.Items.Add("Engineering");
            comboBox1.Items.Add("HR");
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("Production");
        }

        public lightRegistration()
        {
            InitializeComponent();
        }

        public void InfoChecker(string username, string email, MySqlConnection connection)
        {
            string checkusername = "SELECT COUNT(1) FROM bugtracker_users.usersinfo WHERE username = @username";
            string useremail = "SELECT COUNT(1) FROM bugtracker_users.usersinfo WHERE email = @email";

            MySqlCommand checkuser = new MySqlCommand(checkusername, connection);
            MySqlCommand checkemail = new MySqlCommand(useremail, connection);

            checkuser.Parameters.AddWithValue("@username", Vars.username);
            checkemail.Parameters.AddWithValue("@email", Vars.userEmail);

            if (Convert.ToInt32(checkuser.ExecuteScalar()) == 1)
            {
                MessageBox.Show("Username already exists");
            }
            else if (Convert.ToInt32(checkemail.ExecuteScalar()) == 1)
            {
                MessageBox.Show("Email already exists");
            }
            else
            {
                InfoInsertion(Vars.firstName, Vars.lastName, Vars.username, Vars.password, Vars.userEmail, Vars.userDepartment, Vars.levelofAcess, connection);
                LoginPage();
            }

        }

        public void InfoInsertion(string fname, string lname, string username, string password, string email, string department, int level,
            MySqlConnection connection)
        {
            string insert = "INSERT INTO bugtracker_users.usersinfo (fname, lname, username, password, email, department, it_level) VALUES (@fname, @lname" +
                ", @username, @password, @email, @department, @level)";
            MySqlCommand userinsert = new MySqlCommand(insert, connection);

            userinsert.Parameters.AddWithValue("@fname", Vars.firstName);
            userinsert.Parameters.AddWithValue("@lname", Vars.lastName);
            userinsert.Parameters.AddWithValue("@username", Vars.username);
            userinsert.Parameters.AddWithValue("@password", Vars.password);
            userinsert.Parameters.AddWithValue("@email", Vars.userEmail);
            userinsert.Parameters.AddWithValue("@department", Vars.userDepartment);
            userinsert.Parameters.AddWithValue("@level", Vars.levelofAcess);

            if (userinsert.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successfully registered");
            }
            else
            {
                MessageBox.Show("Error registering");
            }
        }

        public void SettingValues()
        {
            Vars.firstName = fNameBox.Text;
            Vars.lastName = lNameBox.Text;
            Vars.username = usernameBox.Text;
            Vars.password = passwordBox.Text;
            Vars.userEmail = emailBox.Text;
            Vars.userDepartment = comboBox1.Text;
            if (radioButton1.Checked == true)
            {
                Vars.levelofAcess = 0;
            }
            else
            {
                Vars.levelofAcess = 1;
            }
        }

        public void LoginPage()
        {
            this.Hide();
            var l = new lightLogin();
            l.Show();
        }

        public void DBOpen(MySqlConnection connection)
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

        public void DBClose(MySqlConnection connection)
        {
            connection.Close();
        }

        private void fNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DBOpen(connection);
            if (CheckRequirements() == false)
            {
                MessageBox.Show("Please fill in all required information");
            }
            else
            {
                SettingValues();
                InfoChecker(Vars.username, Vars.userEmail, connection);
            }
            DBClose(connection);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void lightRegistration_Load(object sender, EventArgs e)
        {
            InitializeDropDown();
        }
    }
}

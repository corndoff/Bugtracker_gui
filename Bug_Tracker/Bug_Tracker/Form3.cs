using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracker
{
    public partial class darkReport : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=*****");
        public darkReport()
        {
            InitializeComponent();
        }

        public static class Vars
        {
            public static string username;
            public static string bugissue;
            public static string date_opened;
            public static string status;
            public static string priority;
            public static string errors = "";
            public static string project = "";
            public static string department;
        }

        public void InitializeDropDown()
        {
            departmentText.Items.Add("Accounting");
            departmentText.Items.Add("Engineering");
            departmentText.Items.Add("HR");
            departmentText.Items.Add("IT");
            departmentText.Items.Add("Production");

            priorityText.Items.Add("Low");
            priorityText.Items.Add("Medium");
            priorityText.Items.Add("High");
        }

        public void SetValues()
        {
            Vars.department = departmentText.Text;
            Vars.username = darkLogin.Vars.username;
            Vars.bugissue = problemText.Text;
            Vars.date_opened = dateText.Text;
            Vars.status = "New";
            Vars.priority = priorityText.Text;
            Vars.errors = errorText.Text;
            Vars.project = projectText.Text;
            
        }

        public void ReportListPage()
        {
            this.Hide();
            var rl = new darkReportList();
            rl.Show();
        }

        public void CheckRequirements()
        {
            if(departmentText.Text =="" || problemText.Text == "" || dateText.Text == "" || priorityText.Text == "")
            {
                MessageBox.Show("Please fill in required information");
            }
            else
            {
                InsertInfo();
                ReportListPage();
            }
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

        public void LoginPage()
        {
            this.Hide();
            var l = new darkLogin();
            l.Show();
        }

        public void InsertInfo()
        {
            DBOpen(connection);
            string insert = "INSERT INTO bugtracker_users.bugissues (username, bugissue, date_opened, status, priority, errors, project, department) VALUES (" +
                "@username, @bugissue, @date_opened, @status, @priority, @errors, @project, @department)";

            MySqlCommand insertion = new MySqlCommand(insert, connection);
            insertion.Parameters.AddWithValue("@username", Vars.username);
            insertion.Parameters.AddWithValue("@bugissue", Vars.bugissue);
            insertion.Parameters.AddWithValue("@date_opened", Vars.date_opened);
            insertion.Parameters.AddWithValue("@status", Vars.status);
            insertion.Parameters.AddWithValue("@priority", Vars.priority);
            insertion.Parameters.AddWithValue("@errors", Vars.errors);
            insertion.Parameters.AddWithValue("@project", Vars.project);
            insertion.Parameters.AddWithValue("@department", Vars.department);

            if(Convert.ToInt32(insertion.ExecuteNonQuery()) == 1)
            {
                MessageBox.Show("The bug was reported. Thank you.");
                
            }
            else
            {
                MessageBox.Show("There was a problem submiting your report");
            }
            DBClose(connection);
        }

        private void departmentText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            SetValues();
            CheckRequirements();
        }

        private void problemText_TextChanged(object sender, EventArgs e)
        {

        }

        private void priorityText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void projectText_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorText_TextChanged(object sender, EventArgs e)
        {

        }

        private void darkReport_Load(object sender, EventArgs e)
        {
            InitializeDropDown();
        }
    }
}

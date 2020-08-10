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

namespace Bug_Tracker
{
    public partial class lightReportList : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=****");
        public lightReportList()
        {
            InitializeComponent();
        }

        public static class Vars
        {
            public static string username = lightLogin.Vars.username;
            public static int reportId;
        }

        public void NewReportPage()
        {
            this.Hide();
            var nr = new lightReport();
            nr.Show();
        }

        public void LoginPage()
        {
            this.Hide();
            var lp = new lightLogin();
            lp.Show();
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

        public void MessagePage()
        {
            this.Hide();
            var mp = new lightMessage();
            mp.Show();
        }

        public void CheckBugNum()
        {
            DBOpen(connection);

            string checkNum = "SELECT COUNT(1) FROM bugtracker_users.bugissues WHERE idbugissues = @id AND username = @username";
            MySqlCommand Num = new MySqlCommand(checkNum, connection);
            Num.Parameters.AddWithValue("@id", Vars.reportId);
            Num.Parameters.AddWithValue("@username", Vars.username);
            int check = Convert.ToInt32(Num.ExecuteScalar());

            if (check == 1)
            {
                MessagePage();
            }
            else
            {
                MessageBox.Show("No report with that id");
            }
            DBClose(connection);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void idText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vars.reportId = Convert.ToInt32(idText.Text);
                CheckBugNum();
            }
            catch (Exception ep)
            {
                MessageBox.Show("Enter a valid number");
                
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void newReportButton_Click(object sender, EventArgs e)
        {
            NewReportPage();
        }

        private void lightReportList_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM bugtracker_users.bugissues WHERE username = @username", connection);
            command.Parameters.AddWithValue("@username", Vars.username);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "users");
            dataGridView2.DataSource = ds.Tables["users"];
            connection.Close();
        }
    }
}

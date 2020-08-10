using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bug_Tracker
{
    public partial class darkReportList : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=****");
        public darkReportList()
        {
            InitializeComponent();  
        }


        public static class Vars
        {
            public static string username = darkLogin.Vars.username;
            public static int reportId;
        }

        private void darkReportList_Load(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM bugtracker_users.bugissues WHERE username = @username", connection);
            command.Parameters.AddWithValue("@username", Vars.username);
            adapter.SelectCommand = command;
            adapter.Fill(ds, "users");
            dataGridView2.DataSource = ds.Tables["users"];
            connection.Close();
        }

        public void NewReportPage()
        {
            this.Hide();
            var nr = new darkReport();
            nr.Show();
        }

        public void LoginPage()
        {
            this.Hide();
            var lp = new darkLogin();
            lp.Show();
        }

        public void DBOpen(MySqlConnection connection)
        {
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void DBClose(MySqlConnection connection)
        {
            connection.Close();
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

        public void MessagePage()
        {
            this.Hide();
            var mp = new darkMessage();
            mp.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
                if (idText.Text == "")
                {
                    MessageBox.Show("Please enter a number");
                }
                else
                {
                    Vars.reportId = Convert.ToInt32(idText.Text);
                    CheckBugNum();
                }
        }

        private void newReportButton_Click(object sender, EventArgs e)
        {
            NewReportPage();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage();
        }
    }
}

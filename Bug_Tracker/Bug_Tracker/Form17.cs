using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Bug_Tracker
{
    public partial class lightMessage : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=*****");

        public lightMessage()
        {
            InitializeComponent();
        }

        public class Vars
        {
            public static string messages = "";
            public static int id;
            public static string issue;
            public static int userLevel;
        }

        public void DBOpen()
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

        public void DBClose()
        {
            connection.Close();
        }

        public void LoginPage()
        {
            this.Hide();
            var lp = new lightLogin();
            lp.Show();
        }

        public void ITReportPage()
        {
            this.Hide();
            var rp = new lightList();
            rp.Show();
        }

        public void RefreshPage()
        {
            this.Hide();
            var re = new lightMessage();
            re.Show();
        }

        public void ReportListPage()
        {
            this.Hide();
            var rl = new lightReportList();
            rl.Show();
        }

        public void CheckForId()
        {
            DBOpen();

            string exists = "SELECT COUNT(1) FROM bugtracker_users.bugmessages WHERE bugissuesid = @id";
            MySqlCommand checking = new MySqlCommand(exists, connection);
            checking.Parameters.AddWithValue("@id", Vars.id);

            int checkid = Convert.ToInt32(checking.ExecuteScalar());
            if (checkid == 1)
            {
                UpdateMessage();
            }
            else
            {
                InsertMessage();
            }

            DBClose();
        }

        public void CheckUsersLevel()
        {
            DBOpen();

            string user = "SELECT it_level FROM bugtracker_users.usersinfo WHERE username = @username";
            MySqlCommand com = new MySqlCommand(user, connection);
            com.Parameters.AddWithValue("@username", lightLogin.Vars.username);

            int checklevel = Convert.ToInt32(com.ExecuteScalar());
            if (checklevel == 1)
            {
                Vars.id = lightList.Vars.commentId;
                Vars.userLevel = 1;
            }
            else
            {
                Vars.id = lightReportList.Vars.reportId;
                Vars.userLevel = 0;
            }
            DBClose();
        }

        public string GetMessages()
        {
            DBOpen();

            string mes = "SELECT * FROM bugtracker_users.bugmessages WHERE bugissuesid = @id";
            MySqlCommand com = new MySqlCommand(mes, connection);
            com.Parameters.AddWithValue("@id", Vars.id);
            string noMessages = "There are no messages on this report.";

            using (var check = com.ExecuteReader())
            {
                if (check.Read())
                {
                    string messages = check.GetString("messages");
                    DBClose();
                    return messages;
                }
                else
                {
                    DBClose();
                    return noMessages;
                }
            }
        }

        public void UpdateMessage()
        {

            string up = "UPDATE bugtracker_users.bugmessages SET messages = CONCAT(messages, @message) WHERE bugissuesid = @id";
            MySqlCommand com = new MySqlCommand(up, connection);
            com.Parameters.AddWithValue("@id", Vars.id);
            com.Parameters.AddWithValue("@message", Vars.messages);

            int checkupdate = Convert.ToInt32(com.ExecuteNonQuery());
            if (checkupdate == 1)
            {
                MessageBox.Show("Message sent");
                RefreshPage();
            }
            else
            {
                MessageBox.Show("Problem sending message");
            }
        }

        public void InsertMessage()
        {

            string insert = "INSERT INTO bugtracker_users.bugmessages (bugissuesid, messages) VALUES (@id, @message)";
            MySqlCommand newcom = new MySqlCommand(insert, connection);
            newcom.Parameters.AddWithValue("@id", Vars.id);
            newcom.Parameters.AddWithValue("@message", Vars.messages);

            int check = Convert.ToInt32(newcom.ExecuteNonQuery());
            if (check == 1)
            {
                MessageBox.Show("Message sent");
                RefreshPage();
            }
            else
            {
                MessageBox.Show("Problem sending message");
            }
        }

        public string GetIssue()
        {
            DBOpen();

            string getIssue = "SELECT bugissue FROM bugtracker_users.bugissues WHERE idbugissues = @id";
            MySqlCommand command = new MySqlCommand(getIssue, connection);
            command.Parameters.AddWithValue("@id", Vars.id);
            string bugissue = Convert.ToString(command.ExecuteScalar());
            DBClose();
            return bugissue;
        }


        private void darkITMessage_Load(object sender, EventArgs e)
        {
            CheckUsersLevel();
            bugIssueIdText.Text = Convert.ToString(Vars.id);
            bugIssueText.Text = GetIssue();
            messageLabel.Text = GetMessages();
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a message to send");
            }
            else
            {
                Vars.messages = lightLogin.Vars.username + "\n" + textBox1.Text + "\n\n";
                CheckForId();
            }
        }

        private void messageLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void reportButton_Click_1(object sender, EventArgs e)
        {
            if (Vars.userLevel == 1)
            {
                ITReportPage();
            }
            else
            {
                ReportListPage();
            }
        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void bugIssueText_Click_1(object sender, EventArgs e)
        {

        }

        private void bugIssueIdText_Click_1(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            RefreshPage();
        }
    }
}

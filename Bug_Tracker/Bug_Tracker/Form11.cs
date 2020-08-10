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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Bug_Tracker
{
    public partial class lightUpdating : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=****");

        public lightUpdating()
        {
            InitializeComponent();
            
        }

        public static class Vars
        {
            public static string status = "";

        }

        public void SetValues()
        {
            Vars.status = statusBox.Text;
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

        public void ListPage()
        {
            this.Hide();
            var l = new lightList();
            l.Show();
        }

        public void UpdateStatus()
        {
            DBOpen(connection);

            string update = "UPDATE bugtracker_users.bugissues SET status = @newstatus WHERE idbugissues = @id ";
            MySqlCommand newStatus = new MySqlCommand(update, connection);
            newStatus.Parameters.AddWithValue("@id", lightList.Vars.statusId);
            newStatus.Parameters.AddWithValue("@newstatus", Vars.status);

            if (Vars.status == "")
            {
                MessageBox.Show("Please enter a new status for the report");
            }
            else
            {

                if (Convert.ToInt32(newStatus.ExecuteNonQuery()) == 1)
                {
                    MessageBox.Show("Updated successfully");
                    ListPage();

                }
                else
                {
                    MessageBox.Show("Error updating status");
                }
            }
            DBClose(connection);
        }

        public void GetStatus()
        {
            DBOpen(connection);

            string get = "SELECT status FROM bugtracker_users.bugissues WHERE idbugissues = @id";
            MySqlCommand getStatus = new MySqlCommand(get, connection);

            getStatus.Parameters.AddWithValue("@id", lightList.Vars.statusId);
            string oldStatus = Convert.ToString(getStatus.ExecuteScalar());
            curStatusText.Text = oldStatus;

            DBClose(connection);
        }

        public string ReporterUsername()
        {
            DBOpen(connection);

            string user = "SELECT username FROM bugtracker_users.bugissues WHERE idbugissues = @id";
            MySqlCommand reportId = new MySqlCommand(user, connection);
            reportId.Parameters.AddWithValue("@id", lightList.Vars.statusId);
            string reportUsername = Convert.ToString(reportId.ExecuteScalar());

            string username = "SELECT email FROM bugtracker_users.usersinfo WHERE username = @username";
            MySqlCommand getUsername = new MySqlCommand(username, connection);
            getUsername.Parameters.AddWithValue("@username", reportUsername);
            string reportEmail = Convert.ToString(getUsername.ExecuteScalar());
            DBClose(connection); 
            return reportEmail;
        }

        public void SendFinishedEmail()
        {

            if(Vars.status == "Finished")
            {
                try
                {
                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Timeout = 10000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("******", "******");
                    MailMessage msg = new MailMessage();
                    msg.To.Add(ReporterUsername());
                    msg.From = new MailAddress("*****");
                    msg.Subject = "Report #" + lightList.Vars.statusId;
                    msg.Body = "Your report is finished";
                    client.Send(msg);
                    MessageBox.Show("Email sent");

                }catch(Exception em)
                {
                    MessageBox.Show(em.Message);
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SendFinishedEmail();
            UpdateStatus();
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vars.status = statusBox.Text;
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            ListPage();
        }

        private void curStatusText_Click(object sender, EventArgs e)
        {

        }

        private void lightUpdating_Load(object sender, EventArgs e)
        {
            statusBox.Items.Add("In Progress");
            statusBox.Items.Add("Finished");
            statusBox.Items.Add("Escalated");
            GetStatus();
            label4.Text = Convert.ToString(lightList.Vars.statusId);
        }
    }
}

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

    public partial class lightList : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=****");

        public lightList()
        {
            InitializeComponent();
        }

        public static class Vars
        {
            public static int statusId;
            public static int commentId;
        }

        public void LoginPage()
        {
            this.Hide();
            var l = new lightLogin();
            l.Show();
        }

        public void UpdatePage()
        {
            this.Hide();
            var up = new lightUpdating();
            up.Show();
        }

        public void CommentPage()
        {
            this.Hide();
            var cp = new lightMessage();
            cp.Show();
        }

        private void idNumText_TextChanged(object sender, EventArgs e)
        {
            
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

        public void CheckBugNumStatus()
        {
            DBOpen(connection);

            string checkNum = "SELECT COUNT(1) FROM bugtracker_users.bugissues WHERE idbugissues = @id";
            MySqlCommand Num = new MySqlCommand(checkNum, connection);
            Num.Parameters.AddWithValue("@id", Vars.statusId);
            int check = Convert.ToInt32(Num.ExecuteScalar());

            if (check == 1)
            {
                UpdatePage();
            }
            else
            {
                MessageBox.Show("No report with that id");
            }
            DBClose(connection);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (idNumText.Text == "")
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                CheckBugNumStatus();
            }
        }

        public void CheckBugNumComment()
        {
            DBOpen(connection);

            string checkNum = "SELECT COUNT(1) FROM bugtracker_users.bugissues WHERE idbugissues = @id";
            MySqlCommand Num = new MySqlCommand(checkNum, connection);
            Num.Parameters.AddWithValue("@id", Vars.commentId);
            int check = Convert.ToInt32(Num.ExecuteScalar());

            if (check == 1)
            {
                CommentPage();
            }
            else
            {
                MessageBox.Show("No report with that id");
            }
            DBClose(connection);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginPage();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugtracker_usersDataSet1.bugissues' table. You can move, or remove it, as needed.
            this.bugissuesTableAdapter.Fill(this.bugtracker_usersDataSet1.bugissues);

        }

        private void commentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            if (commentText.Text == "")
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                Vars.commentId = Convert.ToInt32(commentText.Text);
                CheckBugNumComment();
            }
        }

        private void submitButton_Click_1(object sender, EventArgs e)
        {
            if (idNumText.Text == "")
            {
                MessageBox.Show("Please enter a number");
            }
            else
            {
                Vars.statusId = Convert.ToInt32(idNumText.Text);
                CheckBugNumStatus();
            }
        }
    }
}

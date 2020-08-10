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
    public partial class darkDecision : Form
    {
        public darkDecision()
        {
            InitializeComponent();
        }

        public static class Vars
        {
            public static string selection = "";
        }

        public void ReportPage()
        {
            this.Hide();
            var rp = new darkReportList();
            rp.Show();
        }

        public void NewReportPage()
        {
            this.Hide();
            var nrp = new darkReport();
            nrp.Show();
        }

        public void Decision()
        {
            if (Vars.selection == "")
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                if (Vars.selection == "report")
                {
                    ReportPage();
                }
                else
                {
                    NewReportPage();
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Decision();
        }

        private void reportButton_CheckedChanged(object sender, EventArgs e)
        {
            if(reportButton.Checked == true)
            {
                newReportButton.Checked = false;
                Vars.selection = "report";
            }
        }

        private void newReportButton_CheckedChanged(object sender, EventArgs e)
        {
            if(newReportButton.Checked == true)
            {
                reportButton.Checked = false;
                Vars.selection = "newReport";
            }
        }

        private void darkDecision_Load(object sender, EventArgs e)
        {
            reportButton.Checked = false;
            newReportButton.Checked = false;
        }
    }
}

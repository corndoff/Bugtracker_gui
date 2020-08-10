﻿namespace Bug_Tracker
{
    partial class lightMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.messageLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bugIssueText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bugIssueIdText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.messageLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 166);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.messageLabel.Location = new System.Drawing.Point(2, 0);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(89, 13);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "<new messages>";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click_1);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(540, 5);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(53, 20);
            this.refreshButton.TabIndex = 19;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(144, 305);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(117, 24);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click_1);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(14, 305);
            this.reportButton.Margin = new System.Windows.Forms.Padding(2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(117, 24);
            this.reportButton.TabIndex = 17;
            this.reportButton.Text = "Report Page";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click_1);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(436, 243);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(101, 20);
            this.sendButton.TabIndex = 16;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 243);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 20);
            this.textBox1.TabIndex = 15;
            // 
            // bugIssueText
            // 
            this.bugIssueText.AutoSize = true;
            this.bugIssueText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bugIssueText.Location = new System.Drawing.Point(82, 46);
            this.bugIssueText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bugIssueText.Name = "bugIssueText";
            this.bugIssueText.Size = new System.Drawing.Size(64, 13);
            this.bugIssueText.TabIndex = 14;
            this.bugIssueText.Text = "<bug issue>";
            this.bugIssueText.Click += new System.EventHandler(this.bugIssueText_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Report issue";
            // 
            // bugIssueIdText
            // 
            this.bugIssueIdText.AutoSize = true;
            this.bugIssueIdText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bugIssueIdText.Location = new System.Drawing.Point(82, 9);
            this.bugIssueIdText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bugIssueIdText.Name = "bugIssueIdText";
            this.bugIssueIdText.Size = new System.Drawing.Size(74, 13);
            this.bugIssueIdText.TabIndex = 12;
            this.bugIssueIdText.Text = "<idbugissues>";
            this.bugIssueIdText.Click += new System.EventHandler(this.bugIssueIdText_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Report # ";
            // 
            // lightMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bugIssueText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bugIssueIdText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "lightMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.darkITMessage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label bugIssueText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bugIssueIdText;
        private System.Windows.Forms.Label label1;
    }
}
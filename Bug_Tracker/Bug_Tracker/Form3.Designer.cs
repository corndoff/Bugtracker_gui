namespace Bug_Tracker
{
    partial class darkReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.departmentText = new System.Windows.Forms.ComboBox();
            this.projectText = new System.Windows.Forms.TextBox();
            this.priorityText = new System.Windows.Forms.ComboBox();
            this.dateText = new System.Windows.Forms.DateTimePicker();
            this.errorText = new System.Windows.Forms.RichTextBox();
            this.problemText = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Error message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(355, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date problem started";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description of problem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(355, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Project association";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(355, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "(If applicable)";
            // 
            // departmentText
            // 
            this.departmentText.FormattingEnabled = true;
            this.departmentText.Location = new System.Drawing.Point(141, 63);
            this.departmentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(169, 24);
            this.departmentText.TabIndex = 7;
            this.departmentText.SelectedIndexChanged += new System.EventHandler(this.departmentText_SelectedIndexChanged);
            // 
            // projectText
            // 
            this.projectText.Location = new System.Drawing.Point(520, 58);
            this.projectText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectText.Name = "projectText";
            this.projectText.Size = new System.Drawing.Size(169, 22);
            this.projectText.TabIndex = 8;
            this.projectText.TextChanged += new System.EventHandler(this.projectText_TextChanged);
            // 
            // priorityText
            // 
            this.priorityText.FormattingEnabled = true;
            this.priorityText.Location = new System.Drawing.Point(141, 127);
            this.priorityText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priorityText.Name = "priorityText";
            this.priorityText.Size = new System.Drawing.Size(169, 24);
            this.priorityText.TabIndex = 9;
            this.priorityText.SelectedIndexChanged += new System.EventHandler(this.priorityText_SelectedIndexChanged);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(520, 122);
            this.dateText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(169, 22);
            this.dateText.TabIndex = 10;
            // 
            // errorText
            // 
            this.errorText.BackColor = System.Drawing.Color.White;
            this.errorText.Location = new System.Drawing.Point(175, 190);
            this.errorText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(515, 66);
            this.errorText.TabIndex = 12;
            this.errorText.Text = "";
            this.errorText.TextChanged += new System.EventHandler(this.errorText_TextChanged);
            // 
            // problemText
            // 
            this.problemText.Location = new System.Drawing.Point(175, 305);
            this.problemText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemText.Name = "problemText";
            this.problemText.Size = new System.Drawing.Size(515, 98);
            this.problemText.TabIndex = 13;
            this.problemText.Text = "";
            this.problemText.TextChanged += new System.EventHandler(this.problemText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(237, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Report a Problem";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(172, 450);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(140, 38);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(399, 450);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(140, 38);
            this.loginButton.TabIndex = 16;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(13, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "(If applicable)";
            // 
            // darkReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(725, 523);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.problemText);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.priorityText);
            this.Controls.Add(this.projectText);
            this.Controls.Add(this.departmentText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "darkReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.darkReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox departmentText;
        private System.Windows.Forms.TextBox projectText;
        private System.Windows.Forms.ComboBox priorityText;
        private System.Windows.Forms.DateTimePicker dateText;
        private System.Windows.Forms.RichTextBox errorText;
        private System.Windows.Forms.RichTextBox problemText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label9;
    }
}
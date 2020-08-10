namespace Bug_Tracker
{
    partial class lightReport
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
            this.label9 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.problemText = new System.Windows.Forms.RichTextBox();
            this.errorText = new System.Windows.Forms.RichTextBox();
            this.dateText = new System.Windows.Forms.DateTimePicker();
            this.priorityText = new System.Windows.Forms.ComboBox();
            this.projectText = new System.Windows.Forms.TextBox();
            this.departmentText = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "(If applicable)";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(411, 463);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(140, 38);
            this.loginButton.TabIndex = 33;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(183, 463);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(140, 38);
            this.submitButton.TabIndex = 32;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 29);
            this.label8.TabIndex = 31;
            this.label8.Text = "Report a Problem";
            // 
            // problemText
            // 
            this.problemText.Location = new System.Drawing.Point(187, 318);
            this.problemText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.problemText.Name = "problemText";
            this.problemText.Size = new System.Drawing.Size(515, 98);
            this.problemText.TabIndex = 30;
            this.problemText.Text = "";
            // 
            // errorText
            // 
            this.errorText.BackColor = System.Drawing.Color.White;
            this.errorText.Location = new System.Drawing.Point(187, 203);
            this.errorText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(515, 66);
            this.errorText.TabIndex = 29;
            this.errorText.Text = "";
            this.errorText.TextChanged += new System.EventHandler(this.errorText_TextChanged);
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(531, 135);
            this.dateText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(169, 22);
            this.dateText.TabIndex = 28;
            // 
            // priorityText
            // 
            this.priorityText.FormattingEnabled = true;
            this.priorityText.Location = new System.Drawing.Point(152, 140);
            this.priorityText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priorityText.Name = "priorityText";
            this.priorityText.Size = new System.Drawing.Size(169, 24);
            this.priorityText.TabIndex = 27;
            // 
            // projectText
            // 
            this.projectText.Location = new System.Drawing.Point(531, 71);
            this.projectText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.projectText.Name = "projectText";
            this.projectText.Size = new System.Drawing.Size(169, 22);
            this.projectText.TabIndex = 26;
            // 
            // departmentText
            // 
            this.departmentText.FormattingEnabled = true;
            this.departmentText.Location = new System.Drawing.Point(152, 76);
            this.departmentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentText.Name = "departmentText";
            this.departmentText.Size = new System.Drawing.Size(169, 24);
            this.departmentText.TabIndex = 25;
            this.departmentText.SelectedIndexChanged += new System.EventHandler(this.departmentText_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "(If applicable)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Project association";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description of problem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date problem started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Error message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Department";
            // 
            // lightReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.Name = "lightReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.lightReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox problemText;
        private System.Windows.Forms.RichTextBox errorText;
        private System.Windows.Forms.DateTimePicker dateText;
        private System.Windows.Forms.ComboBox priorityText;
        private System.Windows.Forms.TextBox projectText;
        private System.Windows.Forms.ComboBox departmentText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace Bug_Tracker
{
    partial class lightDecision
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
            this.submitButton = new System.Windows.Forms.Button();
            this.newReportButton = new System.Windows.Forms.RadioButton();
            this.reportButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(13, 88);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(74, 24);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Enter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newReportButton
            // 
            this.newReportButton.AutoSize = true;
            this.newReportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newReportButton.Location = new System.Drawing.Point(13, 60);
            this.newReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newReportButton.Name = "newReportButton";
            this.newReportButton.Size = new System.Drawing.Size(77, 17);
            this.newReportButton.TabIndex = 6;
            this.newReportButton.TabStop = true;
            this.newReportButton.Text = "New report";
            this.newReportButton.UseVisualStyleBackColor = true;
            this.newReportButton.CheckedChanged += new System.EventHandler(this.newReportButton_CheckedChanged_1);
            // 
            // reportButton
            // 
            this.reportButton.AutoSize = true;
            this.reportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportButton.Location = new System.Drawing.Point(13, 38);
            this.reportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(79, 17);
            this.reportButton.TabIndex = 5;
            this.reportButton.TabStop = true;
            this.reportButton.Text = "See reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.CheckedChanged += new System.EventHandler(this.reportButton_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Would you like to see your reports or submit a new report?";
            // 
            // lightDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 128);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newReportButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "lightDecision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.lightDecision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton newReportButton;
        private System.Windows.Forms.RadioButton reportButton;
        private System.Windows.Forms.Label label1;
    }
}
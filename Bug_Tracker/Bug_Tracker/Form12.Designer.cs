namespace Bug_Tracker
{
    partial class darkDecision
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
            this.reportButton = new System.Windows.Forms.RadioButton();
            this.newReportButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Would you like to see your reports or submit a new report?";
            // 
            // reportButton
            // 
            this.reportButton.AutoSize = true;
            this.reportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportButton.Location = new System.Drawing.Point(15, 35);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(103, 21);
            this.reportButton.TabIndex = 1;
            this.reportButton.TabStop = true;
            this.reportButton.Text = "See reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.CheckedChanged += new System.EventHandler(this.reportButton_CheckedChanged);
            // 
            // newReportButton
            // 
            this.newReportButton.AutoSize = true;
            this.newReportButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newReportButton.Location = new System.Drawing.Point(15, 62);
            this.newReportButton.Name = "newReportButton";
            this.newReportButton.Size = new System.Drawing.Size(98, 21);
            this.newReportButton.TabIndex = 2;
            this.newReportButton.TabStop = true;
            this.newReportButton.Text = "New report";
            this.newReportButton.UseVisualStyleBackColor = true;
            this.newReportButton.CheckedChanged += new System.EventHandler(this.newReportButton_CheckedChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(15, 96);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(98, 29);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Enter";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // darkDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(405, 158);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.newReportButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Name = "darkDecision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.darkDecision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton reportButton;
        private System.Windows.Forms.RadioButton newReportButton;
        private System.Windows.Forms.Button submitButton;
    }
}
namespace Bug_Tracker
{
    partial class darkReportList
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
            this.components = new System.ComponentModel.Container();
            this.bugissuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtracker_usersDataSet2 = new Bug_Tracker.bugtracker_usersDataSet2();
            this.bugissuesTableAdapter = new Bug_Tracker.bugtracker_usersDataSet2TableAdapters.bugissuesTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.newReportButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bugissuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtracker_usersDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bugissuesBindingSource
            // 
            this.bugissuesBindingSource.DataMember = "bugissues";
            this.bugissuesBindingSource.DataSource = this.bugtracker_usersDataSet2;
            // 
            // bugtracker_usersDataSet2
            // 
            this.bugtracker_usersDataSet2.DataSetName = "bugtracker_usersDataSet2";
            this.bugtracker_usersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugissuesTableAdapter
            // 
            this.bugissuesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1029, 176);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the report to see messages";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(257, 227);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 22);
            this.idText.TabIndex = 3;
            this.idText.TextChanged += new System.EventHandler(this.idText_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(377, 224);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 25);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newReportButton
            // 
            this.newReportButton.Location = new System.Drawing.Point(20, 277);
            this.newReportButton.Name = "newReportButton";
            this.newReportButton.Size = new System.Drawing.Size(161, 35);
            this.newReportButton.TabIndex = 5;
            this.newReportButton.Text = "New Report";
            this.newReportButton.UseVisualStyleBackColor = true;
            this.newReportButton.Click += new System.EventHandler(this.newReportButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(228, 277);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(161, 35);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // darkReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1061, 359);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.newReportButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "darkReportList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.darkReportList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugissuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtracker_usersDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bugtracker_usersDataSet2 bugtracker_usersDataSet2;
        private System.Windows.Forms.BindingSource bugissuesBindingSource;
        private bugtracker_usersDataSet2TableAdapters.bugissuesTableAdapter bugissuesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button newReportButton;
        private System.Windows.Forms.Button logoutButton;
    }
}
namespace Bug_Tracker
{
    partial class lightList
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idbugissuesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugissueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateopenedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bugissuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugtracker_usersDataSet1 = new Bug_Tracker.bugtracker_usersDataSet1();
            this.bugissuesTableAdapter = new Bug_Tracker.bugtracker_usersDataSet1TableAdapters.bugissuesTableAdapter();
            this.commentButton = new System.Windows.Forms.Button();
            this.commentText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.idNumText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugissuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtracker_usersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbugissuesDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.bugissueDataGridViewTextBoxColumn,
            this.dateopenedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.errorsDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bugissuesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 9);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(888, 197);
            this.dataGridView2.TabIndex = 10;
            // 
            // idbugissuesDataGridViewTextBoxColumn
            // 
            this.idbugissuesDataGridViewTextBoxColumn.DataPropertyName = "idbugissues";
            this.idbugissuesDataGridViewTextBoxColumn.HeaderText = "idbugissues";
            this.idbugissuesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idbugissuesDataGridViewTextBoxColumn.Name = "idbugissuesDataGridViewTextBoxColumn";
            this.idbugissuesDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bugissueDataGridViewTextBoxColumn
            // 
            this.bugissueDataGridViewTextBoxColumn.DataPropertyName = "bugissue";
            this.bugissueDataGridViewTextBoxColumn.HeaderText = "bugissue";
            this.bugissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bugissueDataGridViewTextBoxColumn.Name = "bugissueDataGridViewTextBoxColumn";
            this.bugissueDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateopenedDataGridViewTextBoxColumn
            // 
            this.dateopenedDataGridViewTextBoxColumn.DataPropertyName = "date_opened";
            this.dateopenedDataGridViewTextBoxColumn.HeaderText = "date_opened";
            this.dateopenedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateopenedDataGridViewTextBoxColumn.Name = "dateopenedDataGridViewTextBoxColumn";
            this.dateopenedDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // priorityDataGridViewTextBoxColumn
            // 
            this.priorityDataGridViewTextBoxColumn.DataPropertyName = "priority";
            this.priorityDataGridViewTextBoxColumn.HeaderText = "priority";
            this.priorityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
            this.priorityDataGridViewTextBoxColumn.Width = 125;
            // 
            // errorsDataGridViewTextBoxColumn
            // 
            this.errorsDataGridViewTextBoxColumn.DataPropertyName = "errors";
            this.errorsDataGridViewTextBoxColumn.HeaderText = "errors";
            this.errorsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorsDataGridViewTextBoxColumn.Name = "errorsDataGridViewTextBoxColumn";
            this.errorsDataGridViewTextBoxColumn.Width = 125;
            // 
            // projectDataGridViewTextBoxColumn
            // 
            this.projectDataGridViewTextBoxColumn.DataPropertyName = "project";
            this.projectDataGridViewTextBoxColumn.HeaderText = "project";
            this.projectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projectDataGridViewTextBoxColumn.Name = "projectDataGridViewTextBoxColumn";
            this.projectDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // bugissuesBindingSource
            // 
            this.bugissuesBindingSource.DataMember = "bugissues";
            this.bugissuesBindingSource.DataSource = this.bugtracker_usersDataSet1;
            // 
            // bugtracker_usersDataSet1
            // 
            this.bugtracker_usersDataSet1.DataSetName = "bugtracker_usersDataSet1";
            this.bugtracker_usersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugissuesTableAdapter
            // 
            this.bugissuesTableAdapter.ClearBeforeFill = true;
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(309, 222);
            this.commentButton.Margin = new System.Windows.Forms.Padding(2);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(75, 19);
            this.commentButton.TabIndex = 17;
            this.commentButton.Text = "Submit";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(215, 224);
            this.commentText.Margin = new System.Windows.Forms.Padding(2);
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(76, 20);
            this.commentText.TabIndex = 16;
            this.commentText.TextChanged += new System.EventHandler(this.commentText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 225);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select report to add comment";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(14, 298);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(101, 29);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(309, 254);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 19);
            this.submitButton.TabIndex = 13;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // idNumText
            // 
            this.idNumText.Location = new System.Drawing.Point(215, 255);
            this.idNumText.Margin = new System.Windows.Forms.Padding(2);
            this.idNumText.Name = "idNumText";
            this.idNumText.Size = new System.Drawing.Size(76, 20);
            this.idNumText.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select report to change status";
            // 
            // lightList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 342);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.idNumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "lightList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report List";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugissuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtracker_usersDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private bugtracker_usersDataSet1 bugtracker_usersDataSet1;
        private System.Windows.Forms.BindingSource bugissuesBindingSource;
        private bugtracker_usersDataSet1TableAdapters.bugissuesTableAdapter bugissuesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbugissuesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bugissueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateopenedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.TextBox commentText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox idNumText;
        private System.Windows.Forms.Label label1;
    }
}
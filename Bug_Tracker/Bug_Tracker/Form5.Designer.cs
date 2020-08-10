namespace Bug_Tracker
{
    partial class darkList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.bugtracker_usersDataSet = new Bug_Tracker.bugtracker_usersDataSet();
            this.bugissuesTableAdapter = new Bug_Tracker.bugtracker_usersDataSetTableAdapters.bugissuesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.idNumText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.commentButton = new System.Windows.Forms.Button();
            this.commentText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugissuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtracker_usersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbugissuesDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.bugissueDataGridViewTextBoxColumn,
            this.dateopenedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priorityDataGridViewTextBoxColumn,
            this.errorsDataGridViewTextBoxColumn,
            this.projectDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bugissuesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 237);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.bugissueDataGridViewTextBoxColumn.FillWeight = 250F;
            this.bugissueDataGridViewTextBoxColumn.HeaderText = "bugissue";
            this.bugissueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bugissueDataGridViewTextBoxColumn.Name = "bugissueDataGridViewTextBoxColumn";
            this.bugissueDataGridViewTextBoxColumn.Width = 250;
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
            this.bugissuesBindingSource.DataSource = this.bugtracker_usersDataSet;
            // 
            // bugtracker_usersDataSet
            // 
            this.bugtracker_usersDataSet.DataSetName = "bugtracker_usersDataSet";
            this.bugtracker_usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugissuesTableAdapter
            // 
            this.bugissuesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select report to change status";
            // 
            // idNumText
            // 
            this.idNumText.Location = new System.Drawing.Point(285, 308);
            this.idNumText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idNumText.Name = "idNumText";
            this.idNumText.Size = new System.Drawing.Size(100, 22);
            this.idNumText.TabIndex = 2;
            this.idNumText.TextChanged += new System.EventHandler(this.idNumText_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(411, 306);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(17, 361);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(135, 36);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(411, 267);
            this.commentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(100, 23);
            this.commentButton.TabIndex = 7;
            this.commentButton.Text = "Submit";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // commentText
            // 
            this.commentText.Location = new System.Drawing.Point(285, 269);
            this.commentText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commentText.Name = "commentText";
            this.commentText.Size = new System.Drawing.Size(100, 22);
            this.commentText.TabIndex = 6;
            this.commentText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select report to add comment";
            // 
            // darkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1205, 421);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.idNumText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "darkList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugissuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugtracker_usersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bugtracker_usersDataSet bugtracker_usersDataSet;
        private System.Windows.Forms.BindingSource bugissuesBindingSource;
        private bugtracker_usersDataSetTableAdapters.bugissuesTableAdapter bugissuesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idNumText;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button logoutButton;
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
    }
}
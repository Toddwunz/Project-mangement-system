namespace PMsys
{
    partial class AssigenTaskForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TaskNameCboBox = new System.Windows.Forms.ComboBox();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMDBDataSet = new PMsys.PMDBDataSet();
            this.ProNameCboBox = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.TdutimeTextBox = new System.Windows.Forms.TextBox();
            this.TstartimeTextBox = new System.Windows.Forms.TextBox();
            this.TaskStatusCboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empNameCboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TaskdataGridView = new System.Windows.Forms.DataGridView();
            this.taskTableAdapter = new PMsys.PMDBDataSetTableAdapters.TaskTableAdapter();
            this.projectTableAdapter = new PMsys.PMDBDataSetTableAdapters.ProjectTableAdapter();
            this.employeeTableAdapter = new PMsys.PMDBDataSetTableAdapters.employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TaskName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Task StartTime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Task DueTime ";
            // 
            // TaskNameCboBox
            // 
            this.TaskNameCboBox.DataSource = this.taskBindingSource;
            this.TaskNameCboBox.DisplayMember = "TaskName";
            this.TaskNameCboBox.FormattingEnabled = true;
            this.TaskNameCboBox.Location = new System.Drawing.Point(90, 19);
            this.TaskNameCboBox.Name = "TaskNameCboBox";
            this.TaskNameCboBox.Size = new System.Drawing.Size(121, 21);
            this.TaskNameCboBox.TabIndex = 5;
            this.TaskNameCboBox.ValueMember = "TaskID";
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.pMDBDataSet;
            // 
            // pMDBDataSet
            // 
            this.pMDBDataSet.DataSetName = "PMDBDataSet";
            this.pMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProNameCboBox
            // 
            this.ProNameCboBox.DataSource = this.projectBindingSource;
            this.ProNameCboBox.DisplayMember = "ProjectName";
            this.ProNameCboBox.FormattingEnabled = true;
            this.ProNameCboBox.Location = new System.Drawing.Point(297, 16);
            this.ProNameCboBox.Name = "ProNameCboBox";
            this.ProNameCboBox.Size = new System.Drawing.Size(121, 21);
            this.ProNameCboBox.TabIndex = 6;
            this.ProNameCboBox.ValueMember = "ProjectID";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataMember = "Project";
            this.projectBindingSource.DataSource = this.pMDBDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshButton);
            this.groupBox1.Controls.Add(this.TdutimeTextBox);
            this.groupBox1.Controls.Add(this.TstartimeTextBox);
            this.groupBox1.Controls.Add(this.TaskStatusCboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.empNameCboBox);
            this.groupBox1.Controls.Add(this.TaskNameCboBox);
            this.groupBox1.Controls.Add(this.ProNameCboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 147);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task Details";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(297, 113);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(121, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // TdutimeTextBox
            // 
            this.TdutimeTextBox.Location = new System.Drawing.Point(297, 83);
            this.TdutimeTextBox.Name = "TdutimeTextBox";
            this.TdutimeTextBox.Size = new System.Drawing.Size(121, 20);
            this.TdutimeTextBox.TabIndex = 11;
            this.TdutimeTextBox.Click += new System.EventHandler(this.TdutimeTextBox_Click);
            // 
            // TstartimeTextBox
            // 
            this.TstartimeTextBox.Location = new System.Drawing.Point(91, 83);
            this.TstartimeTextBox.Name = "TstartimeTextBox";
            this.TstartimeTextBox.Size = new System.Drawing.Size(120, 20);
            this.TstartimeTextBox.TabIndex = 10;
            this.TstartimeTextBox.Click += new System.EventHandler(this.TstartimeTextBox_Click);
            // 
            // TaskStatusCboBox
            // 
            this.TaskStatusCboBox.FormattingEnabled = true;
            this.TaskStatusCboBox.Items.AddRange(new object[] {
            "Planning",
            "Processing",
            "Pending",
            "Overdue",
            "Finished"});
            this.TaskStatusCboBox.Location = new System.Drawing.Point(297, 51);
            this.TaskStatusCboBox.Name = "TaskStatusCboBox";
            this.TaskStatusCboBox.Size = new System.Drawing.Size(121, 21);
            this.TaskStatusCboBox.TabIndex = 9;
            this.TaskStatusCboBox.Click += new System.EventHandler(this.TstartimeTextBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Task Staus";
            // 
            // empNameCboBox
            // 
            this.empNameCboBox.DataSource = this.employeeBindingSource;
            this.empNameCboBox.DisplayMember = "empName";
            this.empNameCboBox.FormattingEnabled = true;
            this.empNameCboBox.Location = new System.Drawing.Point(90, 51);
            this.empNameCboBox.Name = "empNameCboBox";
            this.empNameCboBox.Size = new System.Drawing.Size(121, 21);
            this.empNameCboBox.TabIndex = 7;
            this.empNameCboBox.ValueMember = "empID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.pMDBDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Location = new System.Drawing.Point(460, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 147);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(20, 113);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(20, 83);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(117, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(20, 51);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete Assign";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Assign";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TaskdataGridView);
            this.groupBox3.Location = new System.Drawing.Point(13, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 261);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // TaskdataGridView
            // 
            this.TaskdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskdataGridView.Location = new System.Drawing.Point(7, 19);
            this.TaskdataGridView.Name = "TaskdataGridView";
            this.TaskdataGridView.Size = new System.Drawing.Size(595, 236);
            this.TaskdataGridView.TabIndex = 0;
            this.TaskdataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TaskdataGridView_RowHeaderMouseClick);
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // projectTableAdapter
            // 
            this.projectTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AssigenTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AssigenTaskForm";
            this.Text = "AssigenTaskForm";
            this.Load += new System.EventHandler(this.AssigenTaskForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TaskNameCboBox;
        private System.Windows.Forms.ComboBox ProNameCboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox TdutimeTextBox;
        private System.Windows.Forms.TextBox TstartimeTextBox;
        private System.Windows.Forms.ComboBox TaskStatusCboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox empNameCboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TaskdataGridView;
        private PMDBDataSet pMDBDataSet;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private PMDBDataSetTableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private PMDBDataSetTableAdapters.ProjectTableAdapter projectTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PMDBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
    }
}
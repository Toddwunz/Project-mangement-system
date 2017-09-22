namespace PMsys
{
    partial class SalaryBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SlaryButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpComboBox = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMDBDataSet = new PMsys.PMDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new PMsys.PMDBDataSetTableAdapters.employeeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salaryTableAdapter = new PMsys.PMDBDataSetTableAdapters.SalaryTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SlaryButton);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmpComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // SlaryButton
            // 
            this.SlaryButton.Location = new System.Drawing.Point(328, 68);
            this.SlaryButton.Name = "SlaryButton";
            this.SlaryButton.Size = new System.Drawing.Size(121, 23);
            this.SlaryButton.TabIndex = 5;
            this.SlaryButton.Text = "Generate Salary";
            this.SlaryButton.UseVisualStyleBackColor = true;
            this.SlaryButton.Click += new System.EventHandler(this.SlaryButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(328, 29);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Full time",
            "Part time"});
            this.comboBox2.Location = new System.Drawing.Point(125, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Type";
            // 
            // EmpComboBox
            // 
            this.EmpComboBox.DataSource = this.employeeBindingSource;
            this.EmpComboBox.DisplayMember = "empName";
            this.EmpComboBox.FormattingEnabled = true;
            this.EmpComboBox.Location = new System.Drawing.Point(125, 29);
            this.EmpComboBox.Name = "EmpComboBox";
            this.EmpComboBox.Size = new System.Drawing.Size(121, 21);
            this.EmpComboBox.TabIndex = 1;
            this.EmpComboBox.ValueMember = "empID";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.pMDBDataSet;
            // 
            // pMDBDataSet
            // 
            this.pMDBDataSet.DataSetName = "PMDBDataSet";
            this.pMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salry Report";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(7, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(537, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.pMDBDataSet;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // SalaryBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 311);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalaryBill";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EmpComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SlaryButton;
        private System.Windows.Forms.Button SearchButton;
        private PMDBDataSet pMDBDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PMDBDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private PMDBDataSetTableAdapters.SalaryTableAdapter salaryTableAdapter;
    }
}
namespace PMsys
{
    partial class MstaffForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.DOHTextBox = new System.Windows.Forms.TextBox();
            this.PayTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pMDBDataSet = new PMsys.PMDBDataSet();
            this.QATextBox = new System.Windows.Forms.TextBox();
            this.confrimPWTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.DOBTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.jobTableAdapter = new PMsys.PMDBDataSetTableAdapters.JobTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDBDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.GenderComboBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.AdressTextBox);
            this.groupBox1.Controls.Add(this.DOHTextBox);
            this.groupBox1.Controls.Add(this.PayTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.QATextBox);
            this.groupBox1.Controls.Add(this.confrimPWTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.DOBTextBox);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(302, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "User ID";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(302, 56);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(100, 21);
            this.GenderComboBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Adress";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Date Of Hire";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(123, 117);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdressTextBox.TabIndex = 18;
            // 
            // DOHTextBox
            // 
            this.DOHTextBox.Location = new System.Drawing.Point(123, 85);
            this.DOHTextBox.Name = "DOHTextBox";
            this.DOHTextBox.Size = new System.Drawing.Size(100, 20);
            this.DOHTextBox.TabIndex = 17;
            // 
            // PayTextBox
            // 
            this.PayTextBox.Location = new System.Drawing.Point(302, 154);
            this.PayTextBox.Name = "PayTextBox";
            this.PayTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pay Rate";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(17, 125);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(84, 25);
            this.refreshButton.TabIndex = 14;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataSource = this.jobBindingSource;
            this.typeComboBox.DisplayMember = "Jtitle";
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(302, 121);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 13;
            this.typeComboBox.ValueMember = "Jcode";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.pMDBDataSet;
            // 
            // pMDBDataSet
            // 
            this.pMDBDataSet.DataSetName = "PMDBDataSet";
            this.pMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QATextBox
            // 
            this.QATextBox.Location = new System.Drawing.Point(302, 88);
            this.QATextBox.Name = "QATextBox";
            this.QATextBox.Size = new System.Drawing.Size(100, 20);
            this.QATextBox.TabIndex = 12;
            // 
            // confrimPWTextBox
            // 
            this.confrimPWTextBox.Location = new System.Drawing.Point(123, 187);
            this.confrimPWTextBox.Name = "confrimPWTextBox";
            this.confrimPWTextBox.Size = new System.Drawing.Size(100, 20);
            this.confrimPWTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(123, 152);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // DOBTextBox
            // 
            this.DOBTextBox.Location = new System.Drawing.Point(123, 52);
            this.DOBTextBox.Name = "DOBTextBox";
            this.DOBTextBox.Size = new System.Drawing.Size(100, 20);
            this.DOBTextBox.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(123, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "User Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qualification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.AssignButton);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.refreshButton);
            this.groupBox2.Location = new System.Drawing.Point(463, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(107, 125);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 25);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(107, 79);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 25);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(107, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(17, 79);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(84, 25);
            this.AssignButton.TabIndex = 1;
            this.AssignButton.Text = "AssignTask";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(17, 37);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(84, 25);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.userDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(28, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UserList";
            // 
            // userDataGridView
            // 
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(7, 23);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowTemplate.Height = 23;
            this.userDataGridView.Size = new System.Drawing.Size(622, 225);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userDataGridView_RowHeaderMouseClick);
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // MstaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MstaffForm";
            this.Text = "ManageUserForm";
            this.Load += new System.EventHandler(this.MstaffForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMDBDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox QATextBox;
        private System.Windows.Forms.TextBox confrimPWTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox DOBTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.TextBox DOHTextBox;
        private System.Windows.Forms.TextBox PayTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label11;
        private PMDBDataSet pMDBDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private PMDBDataSetTableAdapters.JobTableAdapter jobTableAdapter;
    }
}
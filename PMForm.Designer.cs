namespace PMsys
{
    partial class PMForm
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
            this.staffButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.taskButton = new System.Windows.Forms.Button();
            this.projectButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ProScheButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(64, 19);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(139, 35);
            this.staffButton.TabIndex = 0;
            this.staffButton.Text = "ManageStaff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientButton);
            this.groupBox1.Controls.Add(this.staffButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ManageTool";
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(64, 72);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(139, 35);
            this.clientButton.TabIndex = 1;
            this.clientButton.Text = "ManageClient";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(349, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // loginOutToolStripMenuItem
            // 
            this.loginOutToolStripMenuItem.Name = "loginOutToolStripMenuItem";
            this.loginOutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginOutToolStripMenuItem.Text = "Login out";
            this.loginOutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.taskButton);
            this.groupBox2.Controls.Add(this.projectButton);
            this.groupBox2.Location = new System.Drawing.Point(13, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ManageProject";
            // 
            // taskButton
            // 
            this.taskButton.Location = new System.Drawing.Point(63, 74);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(139, 37);
            this.taskButton.TabIndex = 1;
            this.taskButton.Text = "ManageTask";
            this.taskButton.UseVisualStyleBackColor = true;
            this.taskButton.Click += new System.EventHandler(this.taskButton_Click);
            // 
            // projectButton
            // 
            this.projectButton.Location = new System.Drawing.Point(63, 20);
            this.projectButton.Name = "projectButton";
            this.projectButton.Size = new System.Drawing.Size(139, 36);
            this.projectButton.TabIndex = 0;
            this.projectButton.Text = "ManageProject";
            this.projectButton.UseVisualStyleBackColor = true;
            this.projectButton.Click += new System.EventHandler(this.projectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProScheButton);
            this.groupBox3.Controls.Add(this.billButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // ProScheButton
            // 
            this.ProScheButton.Location = new System.Drawing.Point(64, 80);
            this.ProScheButton.Name = "ProScheButton";
            this.ProScheButton.Size = new System.Drawing.Size(139, 33);
            this.ProScheButton.TabIndex = 1;
            this.ProScheButton.Text = "Project Schedule";
            this.ProScheButton.UseVisualStyleBackColor = true;
            this.ProScheButton.Click += new System.EventHandler(this.ProScheButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(64, 28);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(139, 33);
            this.billButton.TabIndex = 0;
            this.billButton.Text = "Invoices bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // PMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PMForm";
            this.Text = "PMForm";
            this.Load += new System.EventHandler(this.PMForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.Button projectButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ProScheButton;
        private System.Windows.Forms.Button billButton;
    }
}
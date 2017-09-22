using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMsys
{
    public partial class PMForm : Form
    {
        public PMForm()
        {
            InitializeComponent();
        }

        private void PMForm_Load(object sender, EventArgs e)
        {
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                loginform lf = new loginform();
                lf.ShowDialog();
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // go to staffForm if the manageUser button is clicked
        private void staffButton_Click(object sender, EventArgs e)
        {
            MstaffForm sf = new MstaffForm();
            sf.ShowDialog();
        }


        // go to clientForm if the clientButton button is clicked
        private void clientButton_Click(object sender, EventArgs e)
        {
            clientForm cf = new clientForm();
            cf.ShowDialog();
        }

        private void projectButton_Click(object sender, EventArgs e)
        {
            ProjectForm pf = new ProjectForm();
            pf.ShowDialog();
        }

        private void taskButton_Click(object sender, EventArgs e)
        {
            TaskForm tf = new TaskForm();
            tf.ShowDialog();
        }

        private void ProScheButton_Click(object sender, EventArgs e)
        {
            ProjectScheduleFrom psf = new ProjectScheduleFrom();
            psf.ShowDialog();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            ProjectBillFrom pbf = new ProjectBillFrom();
            pbf.ShowDialog();
        }
    }
}

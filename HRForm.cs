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
    public partial class HRForm : Form
    {
        public HRForm()
        {
            InitializeComponent();
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            MstaffForm sf = new MstaffForm();
            sf.ShowDialog();
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

        private void SalaryButton_Click(object sender, EventArgs e)
        {
            SalaryBill sf = new SalaryBill();
            sf.ShowDialog();
        }
    }
}

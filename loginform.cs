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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        public loginform(int uid)
        {
            InitializeComponent();
            userIDTextBox.Text = uid.ToString();
            passwordTextBox.Focus();
        }

        Controller ctr = new Controller();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //userTypeComboBox.SelectedIndex = 0;
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string uid = userIDTextBox.Text.Trim();
            string password = passwordTextBox.Text;


            if (!ctr.idValidator(uid))
            {
                MessageBox.Show("User id should be 1-6 numbers.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                userIDTextBox.Clear();
                userIDTextBox.Focus();
            }
            else if (!ctr.passwordValidator(password))
            {
                MessageBox.Show("Password should be 6-22 characters.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            // looking for the user and the password in a database
            else if (!ctr.checkUser(int.Parse(uid), password))
            {
                MessageBox.Show("User id or password is incorrect, please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            // go to the dentalForm if dental is logging
            else if (GV.Type.Equals("HR"))
            {
                Program.loginID = int.Parse(uid);
                this.Hide();
                HRForm df = new HRForm();
                df.ShowDialog();
                this.Close();
            }
            // go to the receptionistForm if receptionist is logging
            else if (GV.Type.Equals("PM"))
            {
                Program.loginID = int.Parse(uid);
                this.Hide();
                PMForm pf = new PMForm();
                pf.ShowDialog();
                this.Close();
            }
            // go to the managerForm if manager is logging
            else 
            {
               // MessageBox.Show("User type is:"+GV.Type);
                Program.loginID = int.Parse(uid);
                this.Hide();
                staffForm mf = new staffForm(Program.loginID);
                mf.ShowDialog();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ClientLoginForm cf = new ClientLoginForm();
            cf.ShowDialog();
            this.Close();
        }
    }
}

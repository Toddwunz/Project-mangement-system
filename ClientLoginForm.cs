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
    public partial class ClientLoginForm : Form
    {
        public ClientLoginForm()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //userTypeComboBox.SelectedIndex = 0;
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string uid = clientTextBox.Text.Trim();
            string password = passwordTextBox.Text;


            if (!ctr.idValidator(uid))
            {
                MessageBox.Show("User id should be 1-6 numbers.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                clientTextBox.Clear();
                clientTextBox.Focus();
            }
            else if (!ctr.passwordValidator(password))
            {
                MessageBox.Show("Password should be 6-22 characters.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            // looking for the user and the password in a database
            else if (!ctr.checkClient(int.Parse(uid), password))
            {
                MessageBox.Show("Client id or password is incorrect, please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTextBox.Clear();
                passwordTextBox.Focus();
            }
            //Transfer to clientCheckForm
            else
            {
                GV.ClientID = int.Parse(uid);
                this.Hide();
                clientCheckForm mf = new clientCheckForm(GV.ClientID);
                mf.ShowDialog();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

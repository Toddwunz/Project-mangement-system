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
    
    public partial class ChangePerInfo : Form
    {
        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        public delegate void IdentityUpdateHandler(object sender, IdentityUpdateEventArgs e);
        public event IdentityUpdateHandler IdentityUpdated;
        public ChangePerInfo()
        {
            InitializeComponent();
        }

        public ChangePerInfo(int uid)
        {
            InitializeComponent();
            GV.UserId = uid;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {       
            this.Dispose();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            employee user = ctr.getUser(GV.UserId);
            string sNewPhone = PhoneTextBox.Text;
            string sNewQA = QAtextBox.Text;
            string sNewDOB = DOBtextBox.Text;
            string sNewAdd = AddTextBox.Text;
            string sNewPasswd = PwdTextBox.Text;
            string sNewConPasswd = conPwdTextBox.Text;


            if (sNewPhone.Length < 1 || sNewQA.Length < 1 || sNewDOB.Length < 1 || sNewAdd.Length < 1  ||
                           sNewPasswd.Length < 6 || sNewPasswd != sNewConPasswd)
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.updateUserInfo(GV.UserId,sNewDOB,sNewQA,sNewAdd,sNewPasswd);
                IdentityUpdateEventArgs args = new IdentityUpdateEventArgs(sNewDOB, sNewAdd, sNewQA);
                IdentityUpdated(this, args);
                this.Dispose();
            }
        }

        public class IdentityUpdateEventArgs : System.EventArgs
        {
            private string mNewDOB;
            private string mNewAdd;
            private string mNewQA;

            public IdentityUpdateEventArgs(string sNewDOB, string sNewAdd, string sNewQA)
            {
                this.mNewDOB = sNewDOB;
                this.mNewAdd = sNewAdd;
                this.mNewQA = sNewQA;
            }

            public string NewDOB
            {
                get
                {
                    return mNewDOB;
                }
            }

            public string NewAdd
            {
                get
                {
                    return mNewAdd;
                }
            }

            public string NewQA
            {
                get
                {
                    return mNewQA;
                }
            }
        }

        private void ChangePerInfo_Load(object sender, EventArgs e)
        {
            employee user = ctr.getUser(GV.UserId);
            PhoneTextBox.Text = "123456";
            QAtextBox.Text= user.empQA.ToString();
            DOBtextBox.Text = user.empDOB.ToString();
            AddTextBox.Text = user.emAddress.ToString();
        }
    }
}

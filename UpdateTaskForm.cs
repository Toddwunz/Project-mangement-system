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
    public partial class UpdateTaskForm : Form
    {
        public UpdateTaskForm()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        public delegate void IdentityUpdateHandler(object sender, IdentityUpdateEventArgs e);
        public event IdentityUpdateHandler IdentityUpdated;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
           
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
        }
    }
}

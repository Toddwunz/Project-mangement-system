using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;

namespace PMsys
{
    public partial class MstaffForm : Form
    {
        public MstaffForm()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        private void MstaffForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMDBDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.pMDBDataSet.Job);
            refresh();
        }

        private void refresh()
        {
            
            NameTextBox.Clear();
            GenderComboBox.SelectedIndex = 0;
            DOBTextBox.Clear();
            QATextBox.Clear();
            DOHTextBox.Clear();
            typeComboBox.SelectedIndex = 0;
            AdressTextBox.Clear();
            passwordTextBox.Clear();
            confrimPWTextBox.Clear();
            PayTextBox.Clear();
            bindingDateGridView(null);
        }
        private void bindingDateGridView(string name)
        {
            var userlist = from u in db.employees join j in db.Jobs on u.Jcode equals j.Jcode
                           where SqlMethods.Like(u.empName, "%" + name + "%")
                           select new
                           {
                               UserID = u.empID,
                               Name = u.empName,
                               Gender = u.empGender,
                               DateOfBirth = u.empDOB,
                               Qualification = u.empQA,
                               DateOfHire = u.empDOH,
                               PayRate = u.empPayrate,                        
                               Role = j.Jtitle,
                               Address = u.emAddress
                           };
            userDataGridView.DataSource = userlist.Distinct();
        }

        //transfer Jcode to Jtitle
        /*
        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
               
                if (e.ColumnIndex == 1)
                {
                    int val = Convert.ToInt32(e.Value);
                    e.Value = ctr.getJtile(val);
                    e.FormattingApplied = true;
                }
            }
            catch (System.Exception ex)
            {
                e.FormattingApplied = false;
                MessageBox.Show(ex.ToString());
            }
        }
        */
    private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

    private void searchButton_Click(object sender, EventArgs e)
        {
            bindingDateGridView(NameTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string fname = NameTextBox.Text;
            string fgender = GenderComboBox.Text.Trim();
            string fDOB = DOBTextBox.Text;
            string fQA = QATextBox.Text;
            string fDOH = DOHTextBox.Text;
            string Fpay = PayTextBox.Text;
            int type = (int)typeComboBox.SelectedValue;
            string faddress = AdressTextBox.Text;
            string passwd = passwordTextBox.Text;
            string confrim = confrimPWTextBox.Text;

            if (fname.Length < 1 || fgender.Length < 1 || fDOB.Length < 1 || fDOH.Length < 1 || Fpay.Length < 1 ||
                            passwd.Length < 6 || passwd != confrim)
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.addUser(fname, fgender, fDOB, fQA, fDOH,Fpay,type,faddress,passwd);
                //MessageBox.Show("Data is" + type);
            }
            refresh();
        }

        
        private void updateButton_Click(object sender, EventArgs e)
        {
            int uid = 0;
            try
            {
                uid = int.Parse(idTextBox.Text);
                ctr.getUser(uid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            string fname = NameTextBox.Text;
            string fgender = GenderComboBox.Text.Trim();
            string fDOB = DOBTextBox.Text;
            string fQA = QATextBox.Text;
            string fDOH = DOHTextBox.Text;
            string Fpay = PayTextBox.Text;
            int type = (int)typeComboBox.SelectedValue;
            string faddress = AdressTextBox.Text;
            string passwd = passwordTextBox.Text;
            string confrim = confrimPWTextBox.Text;

            if (fname.Length < 1 || fgender.Length < 1 || fDOB.Length < 1 || fDOH.Length < 1 || Fpay.Length < 1 ||
                            passwd.Length < 6 || passwd != confrim)
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.updateUser(uid,fname, fgender, fDOB, fQA, fDOH, Fpay, type, faddress, passwd);
                //MessageBox.Show("Data is" + type);
            }
            refresh();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "All related data will be deleted as well, continue?",
            "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            int uid = 0;
            try
            {
                uid = int.Parse(idTextBox.Text);
                ctr.getUser(uid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            ctr.deleteUser(uid);
        }

        private void userDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int uid = int.Parse(this.userDataGridView.CurrentRow.Cells[0].Value.ToString());
            employee user = ctr.getUser(uid);
            idTextBox.Text = uid.ToString();
            NameTextBox.Text = user.empName;
            DOBTextBox.Text = user.empDOB;
            GenderComboBox.Text = user.empGender;
            DOHTextBox.Text = user.empDOH;
            QATextBox.Text = user.empQA;
            AdressTextBox.Text = user.emAddress;
            typeComboBox.Text = ctr.getJtitlebyUid(uid);
            PayTextBox.Text = user.empPayrate;
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            AssigenTaskForm af = new AssigenTaskForm();
            af.ShowDialog();
        }

    }
}

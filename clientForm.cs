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
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        private void clientForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMDBDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.pMDBDataSet.Project);
            refresh();
        }

        private void refresh()
        {

            NameTextBox.Clear();
            ProjectComboBox.SelectedIndex = 0;
            PhoneTextBox.Clear();
            passwordTextBox.Clear();
            confrimPWTextBox.Clear();
            CommentTextBox.Clear();
            bindingDateGridView(null);
        }
        private void bindingDateGridView(string name)
        {
            var userlist = from u in db.clients
                           join j in db.Projects on u.ProjectID equals j.ProjectID
                           where SqlMethods.Like(u.ClientName, "%" + name + "%")
                           select new
                           {
                               ClientID = u.ClientID,
                               Name = u.ClientName,
                               Phone = u.ClinetPhone,
                               Project = j.ProjectName,
                               Comments = u.Comment
                               
                           };
            userDataGridView.DataSource = userlist.Distinct();
            userDataGridView.Columns[0].Visible = false;
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
            string phone = PhoneTextBox.Text;
            int Project = (int)ProjectComboBox.SelectedValue;
            string comment = CommentTextBox.Text;
            string passwd = passwordTextBox.Text;
            string confrim = confrimPWTextBox.Text;

            if (fname.Length < 1 || comment.Length < 1 || phone.Length < 1 || passwd.Length < 1 ||
                            passwd.Length < 6 || passwd != confrim)
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
               ctr.addClient(fname, phone, Project, comment, passwd);
            }
            refresh();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            int cid = 0;
            try
            {
                cid = int.Parse(idTextBox.Text);
                ctr.getClient(cid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            string fname = NameTextBox.Text;
            string phone = PhoneTextBox.Text;
            int Project = (int)ProjectComboBox.SelectedValue;
            string comment = CommentTextBox.Text;
            string passwd = passwordTextBox.Text;
            string confrim = confrimPWTextBox.Text;

            if (fname.Length < 1 || comment.Length < 1 || phone.Length < 1 || passwd.Length < 1 ||
                            passwd.Length < 6 || passwd != confrim)
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.updateClient(cid, fname, phone, Project, comment, passwd);
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
                ctr.getClient(uid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            ctr.deleteclient(uid);
        }

        private void userDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int uid = int.Parse(this.userDataGridView.CurrentRow.Cells[0].Value.ToString());
            client user = ctr.getClient(uid);
            idTextBox.Text = uid.ToString();
            NameTextBox.Text = user.ClientName;
            PhoneTextBox.Text = user.ClinetPhone;
            ProjectComboBox.Text = ctr.getPnamebyID(uid);
            CommentTextBox.Text = user.Comment;
        }
        
    }
}

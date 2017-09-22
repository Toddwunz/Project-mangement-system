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
using System.Globalization;

namespace PMsys
{
    public partial class ProjectForm : Form
    {
        public ProjectForm()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        private void ProjectForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {

            NameTextBox.Clear();
            idTextBox.Clear();
            budgetTextBox.Clear();
            SDateTextBox.Text = "YYYY/MM/DD";
            DdateTextBox.Text = "YYYY/MM/DD";
            SDateTextBox.ForeColor = Color.Gray;
            DdateTextBox.ForeColor = Color.Gray;
            bindingDateGridView(null);
        }
        private void bindingDateGridView(string name)
        {
            var projectlist = from u in db.Projects
                           where SqlMethods.Like(u.ProjectName, "%" + name + "%")
                           select new
                           {
                               ProjectID = u.ProjectID,
                               Name = u.ProjectName,
                               StartDate = u.StartDate,
                               DueDate = u.DueDate,
                               Budget = u.Budget,
                           };
            userDataGridView.DataSource = projectlist.Distinct();
        }

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
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy/MM/dd hh:mm:ss";

            string fname = NameTextBox.Text;
            DateTime startdate = Convert.ToDateTime(SDateTextBox.Text, dtFormat);
            DateTime duedate = Convert.ToDateTime(DdateTextBox.Text, dtFormat);
            int budget = int.Parse(budgetTextBox.Text);
            string describe = DscribeTextBox.Text;

            if (fname.Length < 1 || SDateTextBox.Text.Length < 1 || DdateTextBox.Text.Length < 1 || budgetTextBox.Text.Length < 1 
                            )
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.addProject(fname, startdate, duedate, budget, describe);
            }
            refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            int pid = 0;
            try
            {
                pid = int.Parse(idTextBox.Text);
                ctr.getProject(pid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy/MM/dd";

            string fname = NameTextBox.Text;
            DateTime startdate = Convert.ToDateTime(SDateTextBox.Text, dtFormat);
            DateTime duedate = Convert.ToDateTime(DdateTextBox.Text, dtFormat);
            int budget = int.Parse(budgetTextBox.Text);
            string describe = DscribeTextBox.Text;

            if (fname.Length < 1 || SDateTextBox.Text.Length < 1 || DdateTextBox.Text.Length < 1 || budgetTextBox.Text.Length < 1
                           )
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.updateProject(pid, fname, startdate, duedate, budget, describe);
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
            int pid = 0;
            try
            {
                pid = int.Parse(idTextBox.Text);
                ctr.getProject(pid);
            }
            catch
            {
                MessageBox.Show("Select one Project first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            ctr.deleteProject(pid);
        }

        private void userDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int pid = int.Parse(this.userDataGridView.CurrentRow.Cells[0].Value.ToString());
            Project pj = ctr.getProject(pid);
            idTextBox.Text = pj.ProjectID.ToString();
            NameTextBox.Text = pj.ProjectName;
            SDateTextBox.Text = pj.StartDate.ToString();
            DdateTextBox.Text =pj.DueDate.ToString();
            budgetTextBox.Text = pj.Budget.ToString();
            DscribeTextBox.Text = pj.Describe;
        }

        private void SDateTextBox_Click(object sender, EventArgs e)
        {
            SDateTextBox.Clear();
            SDateTextBox.ForeColor = Color.Black;
        }

        private void DdateTextBox_Click(object sender, EventArgs e)
        {
            DdateTextBox.Clear();
            DdateTextBox.ForeColor = Color.Black;
        }
    }
}

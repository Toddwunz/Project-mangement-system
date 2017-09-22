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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }
        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        private void TaskForm_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {

            NameTextBox.Clear();
            idTextBox.Clear();
            DscribeTextBox.Clear();
            bindingDateGridView(null);
        }
        private void bindingDateGridView(string name)
        {
            var tasklist = from u in db.Tasks
                              where SqlMethods.Like(u.TaskName, "%" + name + "%")
                              select new
                              {
                                  TaskID = u.TaskID,
                                  TaskName = u.TaskName,
                                  Describe = u.TaskDescribe
                              };
            userDataGridView.DataSource = tasklist.Distinct();
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
            string fname = NameTextBox.Text;
            string describe = DscribeTextBox.Text;

            if (fname.Length <1 )
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.addTask(fname, describe);
            }
            refresh();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            int tid = 0;
            try
            {
                tid = int.Parse(idTextBox.Text);
                ctr.getTask(tid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            string fname = NameTextBox.Text;
            string describe = DscribeTextBox.Text;

            if (fname.Length < 1 )
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                ctr.updateTask(tid, fname, describe);
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
            int tid = 0;
            try
            {
                tid = int.Parse(idTextBox.Text);
                ctr.getTask(tid);
            }
            catch
            {
                MessageBox.Show("Select one Project first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            ctr.deleteTask(tid);
            refresh();
        }

        private void userDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int tid = int.Parse(this.userDataGridView.CurrentRow.Cells[0].Value.ToString());
            Task tk = ctr.getTask(tid);
            idTextBox.Text = tk.TaskID.ToString();
            NameTextBox.Text = tk.TaskName;
            DscribeTextBox.Text = tk.TaskDescribe;
        }

        private void AssignButton_Click(object sender, EventArgs e)
        {
            AssigenTaskForm af = new AssigenTaskForm();
            af.ShowDialog();
        }
    }
}

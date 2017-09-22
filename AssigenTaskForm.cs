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
    public partial class AssigenTaskForm : Form
    {
        int PID;
        public AssigenTaskForm()
        {
            InitializeComponent();
        }
        public AssigenTaskForm(int uid)
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        private void AssigenTaskForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pMDBDataSet.employee);
            // TODO: This line of code loads data into the 'pMDBDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.pMDBDataSet.Project);
            // TODO: This line of code loads data into the 'pMDBDataSet.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.pMDBDataSet.Task);
            refresh();
        }

        private void refresh()
        {  
            TaskNameCboBox.SelectedIndex = 0;
            empNameCboBox.SelectedIndex = 0;
            ProNameCboBox.SelectedIndex = 0;
            TaskStatusCboBox.SelectedIndex = 0;
            TstartimeTextBox.Text = "YYYY/MM/DD hh:mm:ss";
            TdutimeTextBox.Text = "YYYY/MM/DD hh:mm:ss";
            TstartimeTextBox.ForeColor = Color.Gray;
            TdutimeTextBox.ForeColor = Color.Gray;
            bindingDateGridView(null);
        }

        private void bindingDateGridView(string name)
        {
            var ProTask = from u in db.ProjectTasks join t in db.Tasks on u.TaskID equals t.TaskID join p in db.Projects on u.ProjectID equals p.ProjectID join e in db.employees on u.empID equals e.empID
                          where SqlMethods.Like(t.TaskName, "%" + name + "%")
                           select new
                           {
                               TaskID = u.TaskID,
                               TaskName = t.TaskName,
                               ProjectName = p.ProjectName,
                               EmployeeName = e.empName,
                               TaskStartTime = u.StartTime,
                               TaskDuetime = u.DueTime,
                               TaskStatus = u.Status,
                               PorjectTaskID = u.ptID
                           };
            TaskdataGridView.DataSource = ProTask.Distinct();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void TstartimeTextBox_Click(object sender, EventArgs e)
        {
            if (TstartimeTextBox.Text == "YYYY/MM/DD hh:mm:ss")
            {
                TstartimeTextBox.Clear();
                TstartimeTextBox.ForeColor = Color.Black;
            }
                
        }

        private void TdutimeTextBox_Click(object sender, EventArgs e)
        {
            if (TdutimeTextBox.Text == "YYYY/MM/DD hh:mm:ss")
            {
                TdutimeTextBox.Clear();
                TdutimeTextBox.ForeColor = Color.Black;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            bindingDateGridView(TaskNameCboBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            int taskid = (int)TaskNameCboBox.SelectedValue;
            int empid =  (int)empNameCboBox.SelectedValue;
            int proid = (int)ProNameCboBox.SelectedValue;
            string status = TaskStatusCboBox.Text;

            if (taskid.ToString().Length < 1 || empid.ToString().Length < 1 || proid.ToString().Length < 1 
                || status.Length < 1 )
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime startime = DateTime.Parse(TstartimeTextBox.Text);
                    DateTime dutime = DateTime.Parse(TdutimeTextBox.Text);
                 //   MessageBox.Show("taskid:" + taskid + "empid:" + taskid+ "proid："+ proid + "startime: " + startime +"dutime:" + dutime + "status" + status);
                    ctr.addProTask(taskid, proid, empid, startime, dutime, status);
                }
                catch (Exception)
                {
                    MessageBox.Show("Time format is wrong.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                finally
                {
                    refresh();
                }
                //MessageBox.Show("Data is" + startime);
            }
          
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                ctr.getProTask(PID);
            }
            catch
            {
                MessageBox.Show("Select one task first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            int taskid = (int)TaskNameCboBox.SelectedValue;
            int empid = (int)empNameCboBox.SelectedValue;
            int proid = (int)ProNameCboBox.SelectedValue;
            string status = TaskStatusCboBox.Text;
           

            if (taskid.ToString().Length < 1 || empid.ToString().Length < 1 || proid.ToString().Length < 1 || status.Length < 1 
                            )
            {
                MessageBox.Show("Data is incomplete.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime startime = DateTime.Parse(TstartimeTextBox.Text);
                    DateTime dutime = DateTime.Parse(TdutimeTextBox.Text);
                    ctr.updateProTask(taskid, proid, empid, startime, dutime, status, PID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Time format is wrong.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                finally
                {
                    refresh();
                }
                
                //MessageBox.Show("Data is" + type);
            }
            refresh();
        }

        private void TaskdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int pid = (int)this.TaskdataGridView.CurrentRow.Cells[7].Value;
            ProjectTask pj = ctr.getProTask(pid);
            TaskNameCboBox.SelectedValue = pj.TaskID;
            empNameCboBox.SelectedValue = pj.empID;
            ProNameCboBox.SelectedValue = pj.ProjectID;
            TstartimeTextBox.Text = pj.StartTime.ToString();
            TdutimeTextBox.Text = pj.DueTime.ToString();
            TaskStatusCboBox.Text = pj.Status.ToString();
            TstartimeTextBox.ForeColor = Color.Black;
            TdutimeTextBox.ForeColor = Color.Black;
            PID = 0;
            PID = pid;
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "All related data will be deleted as well, continue?",
            "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;
            try
            {
                ctr.getProTask(PID);
            }
            catch
            {
                MessageBox.Show("Select one Project first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            ctr.deleteProTask(PID);
            refresh();
        }
    }
}

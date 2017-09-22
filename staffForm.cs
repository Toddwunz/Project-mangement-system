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
    public partial class staffForm : Form
    {
        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        public staffForm()
        {
            InitializeComponent();
        }

        public staffForm(int uid)
        {
            InitializeComponent();
            employee user = ctr.getUser(uid);
            idLabel.Text = user.empID.ToString();
            nameLabel.Text = user.empName.ToString();
            //    PhoneLabel.Text = user.
            QAlabel.Text = user.empQA.ToString();
            AddLabel.Text = user.emAddress.ToString();
            DOBlabel.Text = user.empDOB.ToString();
            bindingDateGridView(uid);
        }

        private void staffForm_Load(object sender, EventArgs e)
        {

        }

        private void bindingDateGridView(int uid)
        {
            var userlist = from pt in db.ProjectTasks
                           join t in db.Tasks on pt.TaskID equals t.TaskID join p in db.Projects on pt.ProjectID equals p.ProjectID join u in db.employees on pt.empID equals u.empID
                           where u.empID == uid
                           select new
                           {
                               UserID = u.empID,
                               Name = u.empName,
                               TaskName = t.TaskName,
                               ProjectName = p.ProjectName,
                               TaskStartTime = pt.StartTime,
                               TaskDueTime = pt.DueTime,
                               TaskStatus = pt.Status
                           };
            userDataGridView.DataSource = userlist.Distinct();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {

            // ChangePerInfo cp = new ChangePerInfo();
            ChangePerInfo cp = new ChangePerInfo(int.Parse(idLabel.Text));
            cp.IdentityUpdated += new ChangePerInfo.IdentityUpdateHandler(IdForm_ButtonClicked);
            cp.Show();
        }
 
        private void IdForm_ButtonClicked(object sender, ChangePerInfo.IdentityUpdateEventArgs e)
        {
            QAlabel.Text = e.NewQA;
            AddLabel.Text = e.NewAdd;
            DOBlabel.Text = e.NewDOB;
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            UpdateTaskForm cp = new UpdateTaskForm();
        //    cp.IdentityUpdated += new UpdateTaskForm.IdentityUpdateHandler(TaskForm_ButtonClicked);
            cp.Show();
        }
        private void TaskForm_ButtonClicked(object sender, ChangePerInfo.IdentityUpdateEventArgs e)
        {
     //       bindingDateGridView(uid);
        }
    }
}

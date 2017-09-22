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
    public partial class clientCheckForm : Form
    {
        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        public clientCheckForm()
        {
            InitializeComponent();
        }

        public clientCheckForm(int uid)
        {
            InitializeComponent();
            ClientNameLabel.Text = ctr.getClient(uid).ClientName;
            Phonelabel.Text = ctr.getClient(uid).ClinetPhone;         
            int pid = ctr.getClient(uid).ProjectID;
            ProjectLabel.Text = ctr.getProject(pid).ProjectName;
            bindingDateGridView(uid);
        }
        private void bindingDateGridView(int uid)
        {
            var clientlist = from c in db.clients
                           join p in db.Projects on c.ProjectID equals p.ProjectID 
                           where c.ClientID == uid
                           select new
                           {
                               ClientID = c.ClientID,
                               ClientName = c.ClientName,
                               PhoneNumber = c.ClinetPhone,
                               ProjectName = p.ProjectName,
                               StartTime = p.StartDate,
                               Duetime = p.DueDate,
                               Comment =  c.Comment
                           };
            ClientDataGridView.DataSource = clientlist.Distinct();
        }
    }
}

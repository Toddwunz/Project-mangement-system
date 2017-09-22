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
    public partial class ProjectBillFrom : Form
    {
        public ProjectBillFrom()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();

        private void ProjectBillFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMDBDataSet.client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.pMDBDataSet.client);
            bindingDateGridView();
            //this.reportViewer.RefreshReport();
        }

        private void BillButton_Click(object sender, EventArgs e)
        {
            int cid = 0;
            try
            {
                cid = (int)ClientComboBox.SelectedValue;
                ctr.getClient(cid);
            }
            catch
            {
                MessageBox.Show("Select one user first.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (CostTextBox.Text.Length < 1)
            {
                MessageBox.Show("Cost value is Empey.", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                string cost = CostTextBox.Text;
                ctr.updateClient(cid, cost);
                //MessageBox.Show("Data is" + type);
            }
            bindingDateGridView(cid);
        }
        private void bindingDateGridView(int cid)
        {
            var clist = from u in db.clients
                           join j in db.Projects on u.ProjectID equals j.ProjectID
                           where u.ClientID == cid
                           select new
                           {
                               ClientID = u.ClientID,
                               Name = u.ClientName,
                               Project = j.ProjectName,
                               Cost = u.Bill,
                               Comments = u.Comment
                           };
            dataGridView.DataSource = clist.Distinct();
           // dataGridView.Columns[0].Visible = false;
        }

        private void bindingDateGridView()
        {
            var clist = from u in db.clients
                        join j in db.Projects on u.ProjectID equals j.ProjectID
                        select new
                        {
                            ClientID = u.ClientID,
                            Name = u.ClientName,
                            Project = j.ProjectName,
                            Cost = u.Bill,
                            Comments = u.Comment
                        };
            dataGridView.DataSource = clist.Distinct();
            // dataGridView.Columns[0].Visible = false;
        }
    }
}

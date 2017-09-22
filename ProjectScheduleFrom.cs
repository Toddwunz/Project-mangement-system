using System;
using System.Collections;
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
    public partial class ProjectScheduleFrom : Form
    {
        public ProjectScheduleFrom()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        public class SandData
        {
            String key = "";
            Object value = "";
            /// <summary>
            /// 元数据
            /// </summary>
            public SandData() { }
            /// <summary>
            /// 元数据
            /// </summary>
            public SandData(String m_key, Object m_value)
            {
                this.key = m_key;
                this.value = m_value;
            }
            public String Key
            {
                get { return key; }
                set { key = value; }
            }
            public Object Value
            {
                get { return this.value; }
                set { this.value = value; }
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Name = comboBox1.Text.Trim();
            databind(Name);
        }

        private void databind(string name)
        {
            
            if (name == "Project Name")
            {
                ArrayList list1 = new ArrayList();
                var query =
                from p in db.Projects
                select new
                {
                    ProjeID = p.ProjectID,
                    PorjectName = p.ProjectName
                };
                
                foreach (var binddata in query)
                {
                    string text = binddata.PorjectName;
                    int value = binddata.ProjeID;
                    SandData vo = new SandData();
                    vo.Key = text;
                    vo.Value = value;
                    list1.Add(vo);
                }
                comboBox2.DataSource = list1;
            }
            else if (name == "Employee Name")
            {
                ArrayList list2 = new ArrayList();
                var query =
                from p in db.employees
                select new
                {
                    EmpID = p.empID,
                    EmpName = p.empName
                };
                foreach (var binddata in query)
                {
                    
                    string text = binddata.EmpName;
                    int value = binddata.EmpID;
                    SandData vo = new SandData();
                    vo.Key = text;
                    vo.Value = value;
                    list2.Add(vo);
                }
                comboBox2.DataSource = list2;
            }
            else if (name == "ClientName")
            {
                ArrayList list3 = new ArrayList();
                var query =
                from p in db.clients
                select new
                {
                    EmpID = p.ClientID,
                    EmpName = p.ClientName
                };
                foreach (var binddata in query)
                {
                    string text = binddata.EmpName;
                    int value = binddata.EmpID;
                    SandData vo = new SandData();
                    vo.Key = text;
                    vo.Value = value;
                    list3.Add(vo);
                }
                comboBox2.DataSource = list3;
            }
            
            comboBox2.DisplayMember = "Key";
            comboBox2.ValueMember = "Value";
        }
        private void ProjectScheduleFrom_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bindingDateGridView(comboBox2.Text);
        }

        private void bindingDateGridView(string name)
        {
            string tname = comboBox1.Text;
            if (tname == "Project Name")
            {
                var prolist = from p in db.Projects
                               where SqlMethods.Like(p.ProjectName, "%" + name + "%")
                               select new
                               {
                                   ProjectID = p.ProjectID,
                                   ProjectName = p.ProjectName,
                                   ProjectStarDdate = p.StartDate,
                                   ProjectDueDate = p.DueDate,
                                   ProjectBudget = p.Budget,
                                   ProjectDetail = p.Describe
                               };
                dataGridView.DataSource = prolist.Distinct();
                //dataGridView.Columns[0].Visible = false;
            }
            else if (tname == "Employee Name")
            {
                var prolist = from pt in db.ProjectTasks
                               join t in db.Tasks on pt.TaskID equals t.TaskID
                               join p in db.Projects on pt.ProjectID equals p.ProjectID
                               join u in db.employees on pt.empID equals u.empID
                               where SqlMethods.Like(u.empName, "%" + name + "%")  
                               select new
                               {
                                  ProjectID = p.ProjectID,
                                  ProjectName = p.ProjectName,
                                  EmployeeName = u.empName,
                                  ProjectStarDdate = p.StartDate,
                                  ProjectDueDate = p.DueDate,
                                  ProjectBudget = p.Budget,
                                  ProjectDetail = p.Describe
                              };
                dataGridView.DataSource = prolist.Distinct();
            }
            else if (tname == "ClientName")
            {
                var prolist = from c in db.clients
                              join p in db.Projects on c.ProjectID equals p.ProjectID
                              where SqlMethods.Like(c.ClientName, "%" + name + "%")
                              select new
                              {
                                  ProjectID = p.ProjectID,
                                  ProjectName = p.ProjectName,
                                  ClientName = c.ClientName,
                                  ProjectStarDdate = p.StartDate,
                                  ProjectDueDate = p.DueDate,
                                  ProjectBudget = p.Budget,
                                  ProjectDetail = p.Describe
                              };
                dataGridView.DataSource = prolist.Distinct();
            }
        }
    }
}

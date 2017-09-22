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
    public partial class SalaryBill : Form
    {
        public SalaryBill()
        {
            InitializeComponent();
        }

        Controller ctr = new Controller();
        PMSDCDataContext db = new PMSDCDataContext();
        private void Salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMDBDataSet.Salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.pMDBDataSet.Salary);
            // TODO: This line of code loads data into the 'pMDBDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.pMDBDataSet.employee);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bindingDateGridView((int)EmpComboBox.SelectedValue);
        }

        private void SlaryButton_Click(object sender, EventArgs e)
        {
            int cid = (int)EmpComboBox.SelectedValue;
            employee user = new employee();
            user = ctr.getUser(cid);
            DateTime d1 = Convert.ToDateTime(user.empDOH);
            DateTime d2 = DateTime.Now;
            // DateTime d2 = d1.AddDays(1 - (int)d1.DayOfWeek);//2010-4-26 0:00:00
            DateTime d3 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", d1.Year, d1.Month, d1.Day));
            DateTime d4 = Convert.ToDateTime(string.Format("{0}-{1}-{2}", d2.Year, d2.Month, d2.Day));
            int days = (d4 - d3).Days;
            int week = 0;
            for (int i = 0; i <= days; i++)
            {
                DateTime currentDay = d1.AddDays(i);
                if (currentDay.DayOfWeek == DayOfWeek.Friday)
                {
                    week = week + 1;
                    if (week % 2 == 0)
                    {
                        double esalary = 0.0;
                        if (comboBox2.Text == "")
                        {
                            MessageBox.Show("please selease a workType");
                            return;
                        }
                        else if (comboBox2.Text == "Full time")
                        {
                            if (week == 2)
                            {
                                int day = 6 - (int)d1.DayOfWeek + 5;
                                esalary = day * 7.5 * int.Parse(user.empPayrate);
                                string emsalry = esalary.ToString();
                                DateTime enddate = currentDay;
                                DateTime startdata = d1;
                                ctr.addsalary(cid, week, emsalry, comboBox2.Text, startdata, enddate);
                            }
                            else
                            {
                                esalary = 10 * 7.5 * int.Parse(user.empPayrate);
                                string emsalry = esalary.ToString();
                                DateTime enddate = currentDay;
                                DateTime startdata = currentDay.AddDays(-11);
                                ctr.addsalary(cid, week, emsalry, comboBox2.Text, startdata, enddate);
                            }
                        }
                        else if (comboBox2.Text == "Part time")
                        {
                            if (week == 2)
                            {
                                int day = 6 - (int)d1.DayOfWeek + 5;
                                esalary = day * 4.5 * int.Parse(user.empPayrate);
                                string emsalry = esalary.ToString();
                                DateTime enddate = currentDay;
                                DateTime startdata = d1;
                                ctr.addsalary(cid, week, emsalry, comboBox2.Text, startdata, enddate);
                            }
                            else
                            {
                                esalary = 10 * 4.5 * int.Parse(user.empPayrate);
                                string emsalry = esalary.ToString();
                                DateTime enddate = currentDay;
                                DateTime startdata = currentDay.AddDays(-11);
                                ctr.addsalary(cid, week, emsalry, comboBox2.Text, startdata, enddate);
                            }
                        }        
                    }
                }
            }
            bindingDateGridView((int)EmpComboBox.SelectedValue);
        }
                private void bindingDateGridView(int emid)
        {
            var userlist = from j in db.employees
                           join u in db.Salaries on j.empID equals u.empID
                           where u.empID == emid
                           select new
                           {
                               Name = j.empName,
                               DateOfHire = j.empDOH,
                               PayRate = j.empPayrate,
                               SalaryFor2week = u.Salary1,
                               week = u._2week,
                               StartDate = u.StartDate,
                               EndDate = u.EndDate
                           };
            dataGridView.DataSource = userlist.Distinct();
        }
    }
}

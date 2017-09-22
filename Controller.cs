using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Data.Linq.SqlClient;


namespace PMsys
{
    class Controller
    {
        PMSDCDataContext db = new PMSDCDataContext();

        public bool idValidator(string text)
        {
            return Regex.Match(text, "^[\\d]{1,6}$").Success;
        }

        public bool nameValidator(string text)
        {
            return Regex.Match(text, "^[A-Z]{1}[a-z]{1,19}$").Success;
        }

        public bool phoneValidator(string text)
        {
            return Regex.Match(text, "^[\\d]{8,15}$").Success;
        }

        public bool passwordValidator(string text)
        {
            return Regex.Match(text, "^[\\dA-Za-z(!@#$%&)]{6,22}$").Success;
        }

        public bool confirmPasswordValidator(string text1, string text2)
        {
            return text1.Equals(text2);
        }

        public int dateCalculator(DateTime date)
        {
            return (date - DateTime.Now.Date).Days;
        }

        public string GetMd5Hash(string input)
        {
            byte[] data = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        // check username and password
        public bool checkUser(int uid, string password)
        {
            string passwordMD5 = GetMd5Hash(password);
            var user = from u in db.employees
                       where u.empID == uid && u.emPasswd == passwordMD5
                       select u;

            if (user.Any())
            {
                GV.UserId = uid;
                GV.Type = getJtitlebyUid(uid);
                return true;
            }
            return false;
        }

        
        public Job getJob(int Jcode)
        {
           return db.Jobs.First(J => J.Jcode == Jcode);
        }

        // get Jobtype of staff by userID
        public string getJtitlebyUid(int uid)
        {
            employee usr = getUser(uid);
            GV.jcode = usr.Jcode;
            Job jb = getJob(GV.jcode);
            return jb.Jtitle;
        }
        // get Jobtype of staff by Job Code
        public string getJtilebyJid(int Jid)
        {  
            Job jb = getJob(GV.jcode);
            return jb.Jtitle;
        }

        //Get Employee information by EmployeeID
        public employee getUser(int uid)
        {
            return db.employees.First(u => u.empID == uid);
        }

        public int addUser(string fname, string fgender, string fDOB, string fQA, string fDOH, string Fpay, int ftype, string address, string passwd)
        {
            string passwordMD5 = GetMd5Hash(passwd);

            employee user = new employee
            {
                empName = fname,
                empGender = fgender,
                empDOB = fDOB,
                empQA = fQA,
                empDOH = fDOH,
                empPayrate = Fpay,
                Jcode = ftype,
                emPasswd = passwordMD5,
                emAddress = address
            };
            db.employees.InsertOnSubmit(user);
            db.SubmitChanges();
            return user.empID;
        }

        public void updateUser(int uid, string fname, string fgender, string fDOB, string fQA, string fDOH, string Fpay, int ftype, string address, string passwd)
        {
            string passwordMD5 = GetMd5Hash(passwd);
            employee user = getUser(uid);
            user.empName = fname;
            user.empGender = fgender;
            user.empDOB = fDOB;
            user.empQA = fQA;
            user.empDOH = fDOH;
            user.empPayrate = Fpay;
            user.Jcode = ftype;
            user.emPasswd = passwordMD5;
            user.emAddress = address;
            db.SubmitChanges();
        }

        public void updateUserInfo(int uid, string fDOB, string fQA, string address, string passwd)
        {
            string passwordMD5 = GetMd5Hash(passwd);
            employee user = getUser(uid);
            user.empDOB = fDOB;
            user.empQA = fQA;
            user.emPasswd = passwordMD5;
            user.emAddress = address;
            db.SubmitChanges();
        }
        public void deleteUser(int uid)
        {
            db.employees.DeleteOnSubmit(getUser(uid));
          //  deleteReservationByUserID(uid);
          //  deleteLoanByUserID(uid);
            db.SubmitChanges();
        }

        //Operation for client from Here
        public bool checkClient(int uid, string password)
        {
            string passwordMD5 = GetMd5Hash(password);
            var user = from u in db.clients
                       where u.ClientID == uid && u.Passwd == passwordMD5
                       select u;

            if (user.Any())
            {
                GV.ClientID = uid;
                return true;
            }
            return false;
        }
        public client getClient(int uid)
        {
            return db.clients.First(u => u.ClientID == uid);
        }
        //get Project name by ClientID
        public string getPnamebyID(int cid)
        {
            client cl = getClient(cid);
            Project pj = getProject(cl.ProjectID);
            return pj.ProjectName;
        }
        

        public int addClient(string fname,string phone,int Project, string comment,string passwd)
        {
            string passwordMD5 = GetMd5Hash(passwd);

            client user = new client
            {
                ClientName = fname,
                ClinetPhone = phone,
                ProjectID = Project,
                Comment = comment,
                Passwd = passwordMD5
                
            };
            db.clients.InsertOnSubmit(user);
            db.SubmitChanges();
            return user.ClientID;
        }

        public void updateClient(int cid, string bill)
        {
            client user = getClient(cid);
            user.Bill = bill;
            db.SubmitChanges();
        }
        public void updateClient(int cid, string fname, string phone, int Projectid, string comment, string passwd)
        {
            string passwordMD5 = GetMd5Hash(passwd);
            client user = getClient(cid);
            user.ClientName = fname;
            user.ClinetPhone = phone;
            user.ProjectID = Projectid;
            user.Passwd = passwordMD5;
            user.Comment = comment;
            db.SubmitChanges();
        }

        public void deleteclient(int cid)
        {
            db.clients.DeleteOnSubmit(getClient(cid));
            //  deleteReservationByUserID(uid);
            //  deleteLoanByUserID(uid);
            db.SubmitChanges();
        }

        //Project manage operation from here
        public Project getProject(int Pid)
        {
            return db.Projects.First(J => J.ProjectID == Pid);
        }
        public int addProject(string fname, DateTime startdate,DateTime duedate, int budget,string describe)
        {
            Project pro = new Project
            {
                ProjectName = fname,
                StartDate = startdate,
                DueDate = duedate,
                Budget = budget,
                Describe = describe
            };
            db.Projects.InsertOnSubmit(pro);
            db.SubmitChanges();
            return pro.ProjectID;
        }

        public void updateProject(int pid,string fname, DateTime startdate, DateTime duedate, int budget, string describe)
        {
            Project pro = getProject(pid);
            pro.ProjectName = fname;
            pro.StartDate = startdate;
            pro.DueDate = duedate;
            pro.Budget = budget;
            pro.Describe = describe;
            db.SubmitChanges();
        }

        public void deleteProject(int pid)
        {
            db.Projects.DeleteOnSubmit(getProject(pid));
            //  deleteReservationByUserID(uid);
            //  deleteLoanByUserID(uid);
            db.SubmitChanges();
        }

        //Task operation from here
        public Task getTask(int tid)
        {
            return db.Tasks.First(T => T.TaskID == tid);
        }

        public int addTask(string name, string describe)
        {
            Task ts = new Task
            {
                TaskName = name,
                TaskDescribe = describe
            };
            db.Tasks.InsertOnSubmit(ts);
            db.SubmitChanges();
            return ts.TaskID;
        }

        public void updateTask(int tid, string name, string describe)
        {
            Task ts = getTask(tid);
            ts.TaskName = name;
            ts.TaskDescribe = describe;
            db.SubmitChanges();
        }

        public void deleteTask(int tid)
        {
            db.Tasks.DeleteOnSubmit(getTask(tid));
            db.SubmitChanges();
        }


        // Task assignment operation from here
        public ProjectTask getProTask(int ptid)
        {
            return db.ProjectTasks.First(T => T.ptID == ptid);
        }

        public int addProTask(int taskid, int projectid, int empid, DateTime stime, DateTime dtime, string status)
        {
            ProjectTask pt = new ProjectTask
            {
                TaskID = taskid,
                ProjectID = projectid,
                empID = empid,
                StartTime = stime,
                DueTime = dtime,
                Status = status
            };
            db.ProjectTasks.InsertOnSubmit(pt);
            db.SubmitChanges();
            return pt.ptID;
        }

        public void updateProTask(int taskid, int projectid, int empid, DateTime stime, DateTime dtime, string status, int ptid)
        {
            ProjectTask pt = getProTask(ptid);
            pt.TaskID = taskid;
            pt.ProjectID = projectid;
            pt.empID = empid;
            pt.StartTime = stime;
            pt.DueTime = dtime;
            pt.Status = status;
            db.SubmitChanges();
        }
        public void deleteProTask(int ptid)
        {
            db.ProjectTasks.DeleteOnSubmit(getProTask(ptid));
            db.SubmitChanges();
        }

        //Salary generate 
        public void addsalary(int id, int week, string salary, string etype,DateTime t1, DateTime t2)
        {
            if (checkSalary(id, week))
            {
                return;
            }
            Salary st = new Salary
            {
                empID = id,
                _2week = week,
                Salary1 = salary,
                type = etype,
                StartDate = t1,
                EndDate = t2
            };
            db.Salaries.InsertOnSubmit(st);
            db.SubmitChanges();
        }
        public bool checkSalary(int uid, int week)
        {            
            var slar = from u in db.Salaries
                       where u.empID ==uid  && u._2week == week
                       select u;

            if (slar.Any())
            {
                return true;
            }
            return false;
        }
    }
}

using DataAccessLayer.Concrete;
using DZDFreeTim.Business.Abstract;
using DZDFreeTim.Data.Abstract;
using DZDFreeTim.Data.Concreate;
using DZDFreeTim.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZDFreeTim.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        Repository<Employee> repoEmployee = new Repository<Employee>();

        public List<Project> projects = new List<Project>();
        public int[] quarterProjectBonus = new int[4];   // Her çeyrek için ayrı bonus tutan array.

        public List<Issue> ITSMs = new List<Issue>();
        public int[] quarterITSMBonus = new int[4];

        ProjectManager projectm = new ProjectManager();
        ITSMManager itsmm = new ITSMManager();

        //

        private IEmployeeRepository employeeRepository;
        public EmployeeManager()
        {
            employeeRepository = new EmployeeRepository();
        }
        public Employee CreateEmployee(Employee employee)
        {
            return employeeRepository.CreateEmployee(employee);
        }



        public void DeleteEmployee(int id)
        {
            employeeRepository.DeleteEmployee(id);
        }



        public List<Employee> GetAllEmployee()
        {
            return employeeRepository.GetAllEmployee();
        }



        public Employee GetEmployeeById(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }



        public Employee UpdateEmployee(Employee employee)
        {
            return employeeRepository.UpdateEmployee(employee);
        }







        //

        public List<Employee> GetAll()
        {
            return repoEmployee.List();
        }
        public string GetNameById(int id)
        {
            var employee = repoEmployee.GetById(id);
            if (employee == null)
            {
                return String.Empty;
            }
            return employee.Name;
        }
        public string GetEmailById(int id)
        {
            var employee = repoEmployee.GetById(id);
            if (employee == null)
            {
                return String.Empty;
            }
            return employee.Email;
        }
        public DateTime GetEmployementDateById(int id)
        {
            var employee = repoEmployee.GetById(id);
            if (employee == null)
            {
                return DateTime.MinValue;
            }
            return employee.EmployementDate;
        }




        public int CalculateBonusForProjects(int id, int projectMultiplier)
        {
            var employee = repoEmployee.GetById(id);

            var project = projectm.GetAll();
            int ProjectID = 99;
            if (employee.EmployeeType == "developer")
                ProjectID = 0;
            else if (employee.EmployeeType == "analyst")
                ProjectID = 1;
            int FinishedProjects = 0;
            int bonus;
            int projectCapacity = 0;
            DateTime employeeStartingDate = new DateTime();
            employeeStartingDate = employee.EmployementDate.Date;  // Resource başlangıç tarihi  

            if (employee == null)
            {
                return 0;
            }
            else
            {
                foreach (var p in project)
                {
                    if (p.DzdStatus == 14 || p.DzdStatus == 15 || p.DzdStatus == 16 || p.DzdStatus == 17)
                    {
                        if (ProjectID == 0)
                        {
                            if (employee.EmployeeID == p.DeveloperId)
                            {
                                if (!projects.Contains(p))
                                    projects.Add(p);
                                FinishedProjects = p.Effort + FinishedProjects;
                            }
                        }
                        else if (ProjectID == 1)
                        {
                            if (employee.EmployeeID == p.AnalystId)
                            {
                                if (!projects.Contains(p))
                                    projects.Add(p);
                                FinishedProjects = p.Effort + FinishedProjects;
                            }
                        }
                    }
                }
                DateTime currentDate = DateTime.Now;
                string year;
                string month = "";
                string quarter;

                int q1 = 0;
                int q2 = 0;
                int q3 = 0;
                int q4 = 0;

                foreach (var p in projects)
                {
                    int yearInt = currentDate.Year;
                    year = yearInt.ToString();
                    if (currentDate.Month <= 3)
                        month = "-Q1";
                    else if (currentDate.Month > 3 && currentDate.Month <= 6)
                        month = "-Q2";
                    else if (currentDate.Month > 6 && currentDate.Month <= 9)
                        month = "-Q3";
                    else if (currentDate.Month > 9 && currentDate.Month <= 12)
                        month = "-Q4";
                    quarter = year + month;
                    if (p.BillYearQuarter == quarter)
                    {
                        q1++;
                        // prim hesapla quarter bonus 0.indexi arttırıp eşitle
                    }
                    else
                    {
                        currentDate.AddMonths(-3);
                        yearInt = currentDate.Year;
                        year = yearInt.ToString();
                        if (currentDate.Month <= 3)
                            month = "-Q1";
                        else if (currentDate.Month > 3 && currentDate.Month <= 6)
                            month = "-Q2";
                        else if (currentDate.Month > 6 && currentDate.Month <= 9)
                            month = "-Q3";
                        else if (currentDate.Month > 9 && currentDate.Month <= 12)
                            month = "-Q4";
                        quarter = year + month;
                        if (p.BillYearQuarter == quarter)
                        {
                            q2++;
                            // prim hesabı 1.indexe eşitle
                        }
                        else
                        {
                            currentDate.AddMonths(-3);
                            yearInt = currentDate.Year;
                            year = yearInt.ToString();
                            if (currentDate.Month <= 3)
                                month = "-Q1";
                            else if (currentDate.Month > 3 && currentDate.Month <= 6)
                                month = "-Q2";
                            else if (currentDate.Month > 6 && currentDate.Month <= 9)
                                month = "-Q3";
                            else if (currentDate.Month > 9 && currentDate.Month <= 12)
                                month = "-Q4";
                            quarter = year + month;
                            if (p.BillYearQuarter == quarter)
                            {
                                q3++;
                                //prim hesabı 2. indexe eşitle
                            }
                            else
                            {
                                currentDate.AddMonths(-3);
                                yearInt = currentDate.Year;
                                year = yearInt.ToString();
                                if (currentDate.Month <= 3)
                                    month = "-Q1";
                                else if (currentDate.Month > 3 && currentDate.Month <= 6)
                                    month = "-Q2";
                                else if (currentDate.Month > 6 && currentDate.Month <= 9)
                                    month = "-Q3";
                                else if (currentDate.Month > 9 && currentDate.Month <= 12)
                                    month = "-Q4";
                                quarter = year + month;
                                if (p.BillYearQuarter == quarter)
                                {
                                    q4++;
                                    // prim hesabı 3. indexe eşitle
                                }
                            }
                        }
                    }
                }
                // capacitites for each quarter.
                currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 9, 0, 0);
                projectCapacity = (3) * 20;
                if (q1 - projectCapacity < 0)
                    quarterProjectBonus[0] = 0;
                else
                {
                    bonus = (q1 - projectCapacity) * projectMultiplier;
                    quarterProjectBonus[0] = bonus;
                }
                currentDate.AddMonths(-3);
                projectCapacity = (3) * 20;
                if (q2 - projectCapacity < 0)
                    quarterProjectBonus[1] = 0;
                else
                {
                    bonus = (q2 - projectCapacity) * projectMultiplier;
                    quarterProjectBonus[1] = bonus;
                }
                currentDate.AddMonths(-3);
                projectCapacity = (3) * 20;
                if (q3 - projectCapacity < 0)
                    quarterProjectBonus[2] = 0;
                else
                {
                    bonus = (q3 - projectCapacity) * projectMultiplier;
                    quarterProjectBonus[2] = bonus;
                }
                currentDate.AddMonths(-3);   // (pg - pk) * pç
                projectCapacity = (3) * 20;
                if (q4 - projectCapacity < 0)
                    quarterProjectBonus[3] = 0;
                else
                {
                    bonus = (q4 - projectCapacity) * projectMultiplier;
                    quarterProjectBonus[3] = bonus;
                }
            }
            var dateNow = DateTime.Now;
            var totalDays = (dateNow - employee.EmployementDate); // all time capacity
            int months = totalDays.Days / 30;
            projectCapacity = months * 20;
            if (FinishedProjects - projectCapacity < 0)
                return 0;
            else
            {
                bonus = (FinishedProjects - projectCapacity) * projectMultiplier;
                return bonus;
            }


        }

        public int CalculateBonusForITSMs(int id, int itsmMultiplier)
        {
            var employee = repoEmployee.GetById(id);
            var issues = itsmm.GetAll();
            int issueCapacity = 0;


            int FinishedITSMs = 0;
            int bonus;
            if (employee == null)
                return 0;
            else
            {

                foreach (var issue in issues)
                {
                    if ((issue.IssueType == 1 || issue.IssueType == 3) && (issue.Resolution == 1) && (issue.Status == 1))
                    {
                        if (employee.EmployeeID == issue.AssigneeId)
                        {
                            if (!ITSMs.Contains(issue))
                                ITSMs.Add(issue);
                            FinishedITSMs++;
                        }
                    }
                }
                int q1 = 0;
                int q2 = 0;
                int q3 = 0;
                int q4 = 0;
                DateTime currentDate = DateTime.Now;
                DateTime RangeDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 3, DateTime.Now.Day, 9, 0, 0);
                foreach (var issue in ITSMs)
                {
                    string date = issue.Resolved;
                    int checker = 0;
                    string day = "";
                    string month = "";
                    string year = "";
                    for (int i = 0; i < date.Length; i++)
                    {
                        if (date[i] == '.')
                            checker++;
                        else if (date[i] == ' ')
                            break;
                        else
                        {
                            if (checker == 0)
                                day += date[i];
                            else if (checker == 1)
                                month += date[i];
                            else if (checker == 2)
                                year += date[i];
                        }
                    }
                    DateTime issueDate = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day), 9, 0, 0);

                    if (DateTime.Compare(issueDate, RangeDate) >= 0)  // first quarter
                    {
                        q1++;
                    }
                    else
                    {
                        currentDate.AddMonths(-3);
                        RangeDate.AddMonths(-3);
                        if (DateTime.Compare(issueDate, RangeDate) >= 0 && DateTime.Compare(issueDate, RangeDate) < 0)  // second quarter
                        {
                            q2++;
                        }
                        else
                        {
                            currentDate.AddMonths(-3);
                            RangeDate.AddMonths(-3);
                            if (DateTime.Compare(issueDate, RangeDate) >= 0 && DateTime.Compare(issueDate, RangeDate) < 0)  // third quarter
                            {
                                q3++;
                            }
                            else
                            {
                                currentDate.AddMonths(-3);
                                RangeDate.AddMonths(-3);
                                if (DateTime.Compare(issueDate, RangeDate) >= 0 && DateTime.Compare(issueDate, RangeDate) < 0)  // fourth quarter
                                {
                                    q4++;
                                }
                            }
                        }
                    }
                }
                // capacitites and bonuses for each quarter.
                currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 9, 0, 0);
                issueCapacity = (3) * 20;
                if (q1 - issueCapacity < 0)
                    quarterITSMBonus[0] = 0;
                else
                {
                    bonus = (q1 - issueCapacity) * itsmMultiplier;
                    quarterITSMBonus[0] = bonus;
                }
                currentDate.AddMonths(-3);
                issueCapacity = (3) * 20;
                if (q2 - issueCapacity < 0)
                    quarterITSMBonus[1] = 0;
                else
                {
                    bonus = (q2 - issueCapacity) * itsmMultiplier;
                    quarterITSMBonus[1] = bonus;
                }
                currentDate.AddMonths(-3);
                issueCapacity = (3) * 20;
                if (q3 - issueCapacity < 0)
                    quarterITSMBonus[2] = 0;
                else
                {
                    bonus = (q3 - issueCapacity) * itsmMultiplier;
                    quarterITSMBonus[2] = bonus;
                }
                currentDate.AddMonths(-3);
                issueCapacity = (3) * 20;
                if (q4 - issueCapacity < 0)
                    quarterITSMBonus[3] = 0;
                else
                {
                    bonus = (q4 - issueCapacity) * itsmMultiplier;
                    quarterITSMBonus[3] = bonus;
                }
                var dateNow = DateTime.Now;
                var totalDays = (dateNow - employee.EmployementDate); // all time capacity
                int months = totalDays.Days / 30;
                issueCapacity = months * 20;
                if (FinishedITSMs - issueCapacity < 0)
                    return 0;
                else
                {
                    bonus = (FinishedITSMs - issueCapacity) * itsmMultiplier;
                    return bonus;
                }

            }
        }
    }
}
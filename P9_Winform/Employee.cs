using System;
using System.Collections.Generic;
using System.Text;

namespace P9_Winform
{
    #region 1
    //public class Employee
    //{
    //    public int EmployeeId { get; set; }

    //    public string Name { get; set; }

    //    public int Experience { get; set; }

    //    public double Salary { get; set; }

    //    public void IncreaseSalary(List<Employee> Employees)
    //    {
    //        foreach (Employee emp in Employees)
    //        {
    //            if (emp.Salary < 10000)
    //            {
    //                emp.Salary = emp.Salary + emp.Salary * 0.3;
    //            }
    //        }
    //    }
    //}
    #endregion


    #region 2
    public delegate bool SalaryIncreaseEligibility(Employee emp);
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public int Experience { get; set; }

        public double Salary { get; set; }

        public string IncreaseSalary(List<Employee> Employees, SalaryIncreaseEligibility del)
        {
            string sSalIncreasdEmployees = "Salary increased for ";
            foreach (Employee emp in Employees)
            {
                if (del(emp))
                {
                    emp.Salary = emp.Salary + emp.Salary * 0.3;
                    sSalIncreasdEmployees = sSalIncreasdEmployees + emp.Name + " ,";
                }
            }

            return sSalIncreasdEmployees;
        }
    }
    #endregion
}

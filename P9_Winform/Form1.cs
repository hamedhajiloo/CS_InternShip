using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Employee> empList = new List<Employee>();
            //empList.Add(new Employee() { EmployeeId = 100, Name = "Mark", Salary = 2000, Experience = 3 });
            //empList.Add(new Employee() { EmployeeId = 101, Name = "John", Salary = 15000, Experience = 8 });
            //empList.Add(new Employee() { EmployeeId = 102, Name = "David", Salary = 4000, Experience = 4 });
            //empList.Add(new Employee() { EmployeeId = 103, Name = "Bob", Salary = 50000, Experience = 14 });
            //empList.Add(new Employee() { EmployeeId = 104, Name = "Alex", Salary = 9000, Experience = 6 });

            //SalaryIncreaseEligibility del = new SalaryIncreaseEligibility(SalaryEligibility);

            //Employee objEmp = new Employee();
            //string sMsg = objEmp.IncreaseSalary(empList, del);

            //MessageBox.Show(sMsg);

            MessageBox.Show("سلام");
        }

        private bool SalaryEligibility(Employee emp)
        {
            if (emp.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

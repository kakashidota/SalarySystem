using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    internal class Employee
    {
        private int EmployeeId;
        private string Name;
        private double MonthlySalary;

        public Employee(int id, string name, double salary)
        {
            EmployeeId = id;
            Name = name;
            SetSalary(salary);
        }


        public void SetSalary(double salary)
        {

            if (salary >= 0)
            {
                MonthlySalary = salary;
            } else
            {
                Console.WriteLine("Invald salary amount!");
            }
        }

        public int GetId()
        {
            return EmployeeId;
        }

        public double GetSalary()
        {
            return MonthlySalary;
        }

        public string GetName()
        {
            return Name;
        }


    }
}

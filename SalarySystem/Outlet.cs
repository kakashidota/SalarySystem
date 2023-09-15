using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    internal class Outlet
    {
        private string OutletLocation;
        private Employee[] Employees;
        private int CurrentEmployeeCount = 0;

        public Outlet(string location, int maxEmployees)
        {
            OutletLocation = location;
            Employees = new Employee[maxEmployees];
        }

        public void AddEmployee(Employee employee)
        {
            if (CurrentEmployeeCount < Employees.Length)
            {
                Employees[CurrentEmployeeCount] = employee;
                CurrentEmployeeCount++;
            } else
            {
                Console.WriteLine("Outlet has reached maximum employees");
            }
        }

        public double GetTotalOutletSalary()
        {

            double total = 0;
            for (int i = 0; i < CurrentEmployeeCount; i++)
            {
                total += Employees[i].GetSalary();
            }
            
            return total;
        }


        public string GetLocation()
        {
            return OutletLocation;
        }
       

    }
}

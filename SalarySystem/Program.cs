namespace SalarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Frölunda empoyees
            Employee Oliver = new Employee(1, "Oliver", 3000);
            Employee Kymia = new Employee(2, "Kymia", 5000);
            Employee Robin = new Employee(3, "Robin", 10000);
            //nordstand empuyees
            Employee Fatima = new Employee(4, "Fatima", 5000);
            Employee Victor = new Employee(5, "Victor", 10000);
            Employee Raman = new Employee(6, "Raman", 8000);
            Employee Ara = new Employee(7, "Ara", 6500);
            Employee Frank = new Employee(8, "Frank", 3300);


            Outlet frolunda = new Outlet("Frolunda", 10);
            frolunda.AddEmployee(Oliver);
            frolunda.AddEmployee(Robin);
            frolunda.AddEmployee(Kymia);

            Outlet nordstan = new Outlet("Nordstan", 5);
            nordstan.AddEmployee(Fatima);
            nordstan.AddEmployee(Frank);
            nordstan.AddEmployee(Ara);
            nordstan.AddEmployee(Raman);
            nordstan.AddEmployee(Victor);

            Console.WriteLine(frolunda.GetTotalOutletSalary());

            HeadOffice HeadQuarterSweden = new HeadOffice(10);
            HeadQuarterSweden.AddOutlet(frolunda);
            HeadQuarterSweden.AddOutlet(nordstan);

            Console.WriteLine(HeadQuarterSweden.GetTotalCompanySalary());

            //Create a salary system for a company such as mcdonalds
            //There should be diffrent classes that do diffrent things
            //One class for employee CHECK
            //One class for outlet
            //One class for HeadOffice
            //One class for salaries //Optional

            //1. Create 3 more staff
            //2. Create one new outlet
            //3. Add the outlet to the HeadQuarter
            //4. Add the staff to the new outlet
            //5. Add functionallty to remove an employee from an outlet
            //6. Implement a way to give a specific employee a raise by a certain precantage
            //7. Implement a method where each "Employee" can have a role (Manager, staff, janitor)
            //8. Add a bonus  to the employees that have the lowest outlet cost. 20% bonus of total salary
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem
{
    internal class HeadOffice
    {
        private Outlet[] Outlets;
        private int CurrentOutletCounts = 0;

        public HeadOffice(int maxOutlets)
        {
            Outlets = new Outlet[maxOutlets];
        }

        public void AddOutlet(Outlet outlet)
        {
            if(CurrentOutletCounts < Outlets.Length)
            {
                Outlets[CurrentOutletCounts] = outlet;
                CurrentOutletCounts++;
            } else
            {
                Console.WriteLine("HeadOffice has reached a maximum ammount of outlets");
            }
        }

        public double GetTotalCompanySalary()
        {
            double total = 0;
            for (int i = 0; i < CurrentOutletCounts; i++)
            {
                total += Outlets[i].GetTotalOutletSalary();
            }

            return total;
        }


    }
}

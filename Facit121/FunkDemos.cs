using System;

namespace Facit121
{
    public class FunkDemos
    {
        public decimal CalculateSalary(int hours, int timLon)
        {
            if (hours < 10)
                timLon = timLon - 10;
            return hours * timLon;
        }

        public void RitaMeny()
        {
            Console.WriteLine("1. aads");
            Console.WriteLine("2. aads");
            Console.WriteLine("3. aads");
        }

        public void Run()
        {
            while (true)
            {
                RitaMeny();
                int sel = Convert.ToInt32(Console.ReadLine());
            }

            decimal r = CalculateSalary(6, 100);
            r = CalculateSalary(12, 100);
            string s = Console.ReadLine();
        }
    }
}
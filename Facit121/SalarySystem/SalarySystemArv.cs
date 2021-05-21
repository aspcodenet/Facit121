using System;
using System.Collections.Generic;

namespace Facit121.SalarySystem
{
    public class BasEmployee
    {
        public string Name { get; set; }


        public virtual int CalculateSalary(int hoursWorked)
        {
            return 0;
        }

        public BasEmployee(string name)
        {
            Name = name;
        }        
    }

    public class BossEmployee : BasEmployee
    {
        public BossEmployee(string name, int monthlySalary, int hourlySalary )
            :base(name)
        {
            MonthlySalary = monthlySalary;
            HourlySalary = hourlySalary;
        }
        public int MonthlySalary { get; set; }
        public int HourlySalary { get; set; }

        public override int CalculateSalary(int hoursWorked)
        {
            int salary = MonthlySalary + (HourlySalary * hoursWorked);
            if (hoursWorked > 80)
            {
                decimal s = Convert.ToDecimal(salary) * 1.1m;
                salary = Convert.ToInt32(s);
            }

            return salary;

        }
    }

    public class HourlyEmployee : BasEmployee
    {
        public HourlyEmployee(string name, int hourlySalary)
            : base(name)
        {
            HourlySalary = hourlySalary;
        }
        public int HourlySalary { get; set; }

        public override int CalculateSalary(int hoursWorked)
        {
            return hoursWorked * HourlySalary;
        }
    }


    public class MonthlyEmployee : BasEmployee
    {
        public MonthlyEmployee(string name, int monthlySalary)
            : base(name)
        {
            MonthlySalary = monthlySalary;
        }
        public int MonthlySalary { get; set; }

        public override int CalculateSalary(int hoursWorked)
        {
            return MonthlySalary;
        }
    }



    public class SalarySystemArv
    {
        public void Run()
        {
            var employees = new List<BasEmployee>();
            employees.Add(new BossEmployee( "Stefan", 50000, 100));
            employees.Add(new HourlyEmployee("Oliver", 50));
            employees.Add(new MonthlyEmployee("Josefine", 20000));

            //Den 24:e körs lönekörningen
            foreach (var employee in employees)
            {
                Console.WriteLine($"Hur många timmar har {employee.Name} jobbat?");
                int hoursWorked = Convert.ToInt32(Console.ReadLine());
                int salary = employee.CalculateSalary(hoursWorked);
                Console.WriteLine($"Lönen blir:{salary}");
            }
        }
    }
}
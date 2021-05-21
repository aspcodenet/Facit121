using System;
using System.Collections.Generic;

namespace Facit121.SalarySystem
{
    public enum EmployeeType
    {
        None,
        Boss,  // Grundlön monthlySalary + hoursworked * hourlysalary . Om hoursworked > 80 så 10 % extra!
        HourlyWorker, // hoursworked * hourlysalary
        MonthlyWorker // monthlysalary
    }
    public class Employee
    {
        public EmployeeType Type { get; set; }
        public string Name { get; set; }
        public int MonthlySalary { get; set; }
        public int HourlySalary { get; set; }

        public int CalculateSalary(int hoursWorked)
        {
            if (Type == EmployeeType.MonthlyWorker)
            {
                return MonthlySalary;
            }
            else if (Type == EmployeeType.HourlyWorker)
            {
                return hoursWorked * HourlySalary;
            }

            else if (Type == EmployeeType.Boss)
            {
                int salary = MonthlySalary + (HourlySalary * hoursWorked);
                if (hoursWorked > 80)
                {
                    decimal s = Convert.ToDecimal(salary) * 1.1m;
                    salary =  Convert.ToInt32(s);
                }

                return salary;
            }
            return 0;
        }

        public Employee(EmployeeType type, string name, int monthlySalary, int hourlySalary )
        {
            Type = type;
            Name = name;
            MonthlySalary = monthlySalary;
            HourlySalary = hourlySalary;
        }        
    }

    public class SalarySystem
    {
        public void Run() 
        {
            // var daggDjur = new List<Daggdjur>();
            //daggDjur.Add(new Manniska());
            //daggDjur.Add(new Hund());
            //daggDjur.Add(new Katt());



            var employees = new List<Employee>();
            employees.Add(new Employee(EmployeeType.Boss, "Stefan", 50000, 100));
            employees.Add(new Employee(EmployeeType.HourlyWorker, "Oliver", 0, 50));
            employees.Add(new Employee(EmployeeType.MonthlyWorker, "Josefine", 20000, 0));

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
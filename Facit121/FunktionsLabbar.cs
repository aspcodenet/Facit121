using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace Facit121
{
    public class FunktionsLabbar
    {
        public string PrintMessage()
        {
            return "Hello World!";
        }


        public void Lab1()
        {
            string message = PrintMessage();
            Console.WriteLine(message);
        }



        public string PlussaStringar(string s1, string s2)
        {
            return s1 + s2;
        }

        public void Lab2()
        {
            string resultat = "";
            string start = "Hej ";
            string end = "hopp";
            //int a = (1 + 3) + 456;
            string pls = PlussaStringar(start, end);
            pls = pls.ToLower();
            resultat = pls;
        }




        public int CalculateVat(int belopp)
        {
            return Convert.ToInt32(belopp * 0.25m);
        }

        public void Lab3()
        {
            int belopp = Convert.ToInt32(Console.ReadLine());
            int vat = CalculateVat(belopp);

//            vat = CalculateVat(100);
            Console.WriteLine(vat);
            //Console.WriteLine(CalculateVat(100));
        }


        public void RitaMeny()
        {
            Console.WriteLine("1. kjlsdaf");
            Console.WriteLine("2. kjlsdaf");
            Console.WriteLine("3. kjlsdaf");
        }

        public void Run()
        {
            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
        }



        public string HittaLangstaOrdet(List<string> orden)
        {
            string longestSoFar = orden.First();

            foreach (var s in orden)
            {
                if (s.Length > longestSoFar.Length)
                {
                    longestSoFar = s;
                }
            }

            return longestSoFar;
        }

        public void Lab5()
        {
            List<string> ord = new List<string>();
            ord.Add("Hej");
            ord.Add("Stefan");
            ord.Add("Stef");

            string langsta = HittaLangstaOrdet(ord);
        }


        public bool IsMyndig(int age)
        {
            return age >= 18;
        }
        public void Lab4()
        {
            Console.WriteLine("Hur många år är du");
            int age = Convert.ToInt32(Console.ReadLine());

            
            if (IsMyndig(age)) // Samma sak if (age>=18)
                Console.WriteLine("Du är myndig");
            else
                Console.WriteLine("Du är inte myndig");
        }

        public void Lab6()
        {
            while (true)
            {
                Console.WriteLine("Ange en lön");
                int salary = Convert.ToInt32(Console.ReadLine());
                int taxes = CalculateTaxesOnSalary(salary);
                Console.WriteLine($"Tjänar du {salary} blir skatten {taxes}");
            }
            
        }

        private int CalculateTaxesOnSalary(int salary)
        {
            if (salary >= 30000)
                return Convert.ToInt32(salary*0.33);
            if (salary < 15000)
                return Convert.ToInt32(salary * 0.12);
            return Convert.ToInt32(salary * 0.28);
        }

        public void Lab7()
        {
            bool v = IsVokal('a');
        }

        private bool IsVokal(char c)
        {
            char[] vokals = { 'a','o','u','å','e','i','y','ä','ö' };
            return vokals.Contains(Char.ToLower(c));
        }

        public void Lab8()
        {
            while (true)
            {
                Console.WriteLine("Ange en text");
                string input = Console.ReadLine();
                string rovarSprak = Translate(input);
                Console.WriteLine(rovarSprak);
            }
        }

        private string Translate(string input)
        {
            string translated = "";
            foreach (char ch in input)
            {
                if (IsVokal(ch))
                    translated += ch;
                
                else if (char.IsWhiteSpace(ch) == false)
                    translated += ch + "o" + ch;
            }

            return translated;
        }

    }
}
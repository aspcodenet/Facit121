using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}
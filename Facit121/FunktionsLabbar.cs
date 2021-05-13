using System;
using System.Collections.Generic;
using System.Linq;

namespace Facit121
{
    public class FunktionsLabbar
    {
        static string PrintMessage()
        {
            return "Hello World!";
        }


        void Lab1()
        {
            string message = PrintMessage();
            Console.WriteLine(message);
        }



        public string PlussaStringar(string s1, int s2)
        {
            return s1 + s2;
        }

        void Lab2()
        {
            string resultat = "";
            string start = "Hej ";
            string end = "hopp";
            resultat = PlussaStringar(start, end);
        }




        public int CalculateVat(int belopp)
        {
            return Convert.ToInt32(belopp * 0.25m);
        }

        void Lab3()
        {
            Console.WriteLine(CalculateVat(100));
        }


        public void Run()
        {
            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
        }



        string HittaLangstaOrdet(List<string> orden)
        {
            string longestSoFar = orden.First();

            foreach (var s in orden)
            {
                if (s.Length > longestSoFar.Length)
                {
                    longestSoFar = s;
                }
            }
        }

        void Lab5()
        {
            List<string> ord = new List<string>();
            ord.Add("Hej");
            ord.Add("Stefan");
            ord.Add("Stef");

            string langsta = HittaLangstaOrdet(ord);
        }


        bool IsMyndig(int age)
        {
            return age >= 18;
        }
        private void Lab4()
        {
            Console.WriteLine("Hur många år är du");
            int age = Convert.ToInt32(Console.ReadLine());
            if (IsMyndig(age))
                Console.WriteLine("Du är myndig");
            else
                Console.WriteLine("Du är inte myndig");
        }
    }
}
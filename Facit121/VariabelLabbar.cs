using System;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Facit121
{
    public class VariabelLabbar
    {
        public void Run()
        {
            Lab2();
            Lab3();
            Lab4();
            Lab5();
            Lab6();
            Lab7();
            Lab8();
            Lab9();
        }


        private void Lab9()
        {
            Console.WriteLine("Mata in minuter");
            int minuter = Convert.ToInt32(Console.ReadLine());

            //Går heltalsdivision och rest osv men vi kör en LOOP för att träna på det
            int hours = 0;
            while (minuter >= 60)
            {
                hours++;
                minuter -= 60;
            }


            Console.WriteLine("Timmar: {hours} och minuter: {minuter}");
        }




        private void Lab8()
        {
            Console.WriteLine("Mata in pris:");
            decimal summa = Convert.ToDecimal(Console.ReadLine());

            decimal moms = summa * 0.25m;

            Console.WriteLine("Pris med moms: {summa+moms}");
        }


        private void Lab7()
        {
            Console.WriteLine("Mata in tal 1:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in tal 2:");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Summa {tal1+tal2}, Diff: {tal1-tal2}, Medel: {(tal1+tal2)/2}");
        }

        private void Lab6()
        {
            Console.WriteLine("Mata in ditt födelseår:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int years = 2021 - tal1;
            Console.WriteLine("Du är ungefär {years}");

            DateTime idag = DateTime.Now;
            years = idag.Year - tal1;
            Console.WriteLine("Du är ungefär {years}");


        }


        private void Lab5()
        {
            Console.WriteLine("Mata in tal 1:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in tal 2:");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Summan av {tal1} och {tal2} är {tal1+tal2}");
        }

        private void Lab4()
        {
            string fornamn = "Stefan";
            string efternamn = "Holmberg";
            Console.WriteLine($"Jag heter {fornamn}, {efternamn}");
        }

        private void Lab3()
        {
            string namn = "Stefan";
            int age = 48;
            Console.WriteLine($"Jag heter {namn} och är {age} år");
        }

        private void Lab2()
        {
            string namn = "Stefan";
            Console.WriteLine($"Hello {namn}");
        }
    }
}
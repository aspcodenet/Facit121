using System;

namespace Facit121
{
    public class IfLabbar
    {

        void Lab1()
        {
            Console.WriteLine("Mata in ett tal");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("Talet är större än 10");
            }
            else if (n < 10)
            {
                Console.WriteLine("Talet är större än 10");
            }
        }

        public void Run()
        {
            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
            Lab6();
            Lab7();
            Lab8();
        }

        private void Lab8()
        {
            Console.WriteLine("Mata in pengar");
            int kronor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Har du rabatt J/N?");
            string rab = Console.ReadLine();
            bool rabatt = false;
            if (rab == "J")
                rabatt = true;

            if (kronor >= 15 && kronor <= 25)
            {
                if (rabatt)
                {
                    Console.WriteLine("Du kan köpa en liten hamburgare och en pommes frites");
                }
                else
                {
                    Console.WriteLine("Du kan köpa en liten hamburgare");
                }
            }
            else if (kronor > 25 && kronor <= 50)
            {
                if (rabatt)
                {
                    Console.WriteLine("Du kan köpa en stor hamburgare och en pommes frites");
                }
                else
                {
                    Console.WriteLine("Du kan köpa en stor hamburgare");
                }
            }


            else if (kronor > 60 ||  ( kronor > 50 && kronor <= 60 && rabatt )  )
            {
                Console.WriteLine(" Du kan köpa ett meal med dryck");
            }


        }

        private void Lab7()
        {
            Console.WriteLine("Mata in land");
            string land = Console.ReadLine();
            if (land == "Sverige" || land == "Danmark" || land == "Norge")
            {
                Console.WriteLine("Du bor i Skandinavien");
            }
            else
            {
                Console.WriteLine("Du bor inte i Skandinavien");
            }
        }

        private void Lab6()
        {
            Console.WriteLine("Ange ditt födelseår");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 1980 && age < 1990)
            {
                Console.WriteLine("Du är född på åttitalet");
            }
            else if (age >= 1990 && age < 2000)
            {
                Console.WriteLine("Du är född på 90-talet");
            }
            else
            {
                Console.WriteLine("Du är inte född på 1990 eller 1980-talet");
            }
        }

        private void Lab5()
        {
            Console.WriteLine("Ange din kategori V=vuxen   P=pensionär  S=student ");
            string kat = Console.ReadLine();
            if (kat == "P" || kat == "S")
            {
                Console.WriteLine("Kostar 20 kr");
            }
            else if (kat == "V" )
            {
                Console.WriteLine("Kostar 30 kr");
            }
            else
            {
                Console.WriteLine("Du skriev in en ogiltig kategori. V P eller S tack");
            }
        }

        private void Lab4()
        {
            Console.WriteLine("Mata in ålder:");
            int age = Convert.ToInt32(Console.ReadLine());
            string message = "";
            if (age < 18)
            {
                message = "Ej myndig";
            }
            else if (age > 65)
            {
                message = "Pensionär";
            }
            Console.WriteLine(message);

        }

        private void Lab3()
        {
            Console.WriteLine("Ange temperatur");
            decimal d = Convert.ToDecimal(Console.ReadLine());
            if (d > 39.5m)
            {
                Console.WriteLine("Du bör uppsöka läkare!");
            }
            else if (d > 37.8m)
            {
                Console.WriteLine("Du har feber!");
            }
            else if (d < 37.8m)
            {
                Console.WriteLine("Du har inte feber");
            }
        }

        private void Lab2()
        {
            Console.WriteLine("Hur många liter mjölk finns det?");
            int liter = Convert.ToInt32(Console.ReadLine());
            if (liter < 10)
            {
                Console.WriteLine("Beställ 30 paket");
            }
            else if (liter > 10 && liter < 20)
            {
                Console.WriteLine("Beställ 20 paket");
            }
            else
            {
                Console.WriteLine("Du behöver inte beställa nån mjölk");
            }
        }
    }
}
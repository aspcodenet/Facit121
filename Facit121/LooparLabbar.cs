﻿using System;
using System.Collections.Generic;

namespace Facit121
{
    public class LooparLabbar
    {
        public void Run()
        {
            Lab1();
            Lab2();
            Lab3();
            Lab4();
            Lab5();
            Lab6a();
            Lab6b();
        }

        public void Lab6b()
        {
            List<decimal> talen = new List<decimal>();
            while (true)
            {
                Console.WriteLine("Skriv in temp");
                decimal d = Convert.ToDecimal(Console.ReadLine());
                talen.Add(d);
                while(talen.Count > 3)
                    talen.RemoveAt(0);

                decimal summa = 0;
                foreach (var tal in talen)
                    summa += tal;

                Console.WriteLine($"Medel: {summa / talen.Count}");
            }
        }



        public void Lab6a()
        {
            decimal newest = 0;
            decimal middle = 0;
            decimal oldest = 0;
            int count = 0;
            while (true)
            {
                Console.WriteLine("Skriv in temp");
                decimal d = Convert.ToDecimal(Console.ReadLine());
                oldest = middle;
                middle = newest;
                newest = d;
                count++;
                if (count == 1)
                {
                    Console.WriteLine($"Medel: {newest}");
                }
                else if (count == 2)
                {
                    Console.WriteLine($"Medel: {(newest+middle)/2m}");
                }
                else
                {
                    Console.WriteLine($"Medel: {(newest + middle + oldest) / 3m}");
                }
            }
        }

        static void Lab3()
        {
            while (true)
            {
                Console.WriteLine("Mata in tal 1");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mata in tal 2");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int summa = tal1 + tal2;

                Console.WriteLine($"Summa av {tal1} och {tal2} är {summa}");
                Console.WriteLine("Skriv sedan en fråga- Vill du fortsätta(J/N)?");
                // VI ÄNDRAR TILL JA/NEJ
                //Console.WriteLine("Skriv sedan en fråga- Vill du fortsätta(JA/NEJ)?");

                string cont;

                while (true)
                {
                    cont = Console.ReadLine();
                    cont = cont.ToUpper();
                    if (cont == "J" || cont == "N")
                    {
                        break;
                    }
                    Console.WriteLine("Skriv in J eller N tack");
                }


                if (cont == "N")
                {
                    break;
                }


            }


        }


        void Lab4()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                //Mata in 10 tal och plussa på varje till sum
                Console.WriteLine($"Mata in tal {i}:");
                int tal = Convert.ToInt32(Console.ReadLine());
                //sum = sum + tal;
                sum += tal;

            }
            Console.WriteLine($"Summan {sum}");
        }


        void Lab4While()
        {
            int sum = 0;
            int i = 1;
            while (i <= 10)
            {
                //Mata in 10 tal och plussa på varje till sum
                Console.WriteLine($"Mata in tal {i}:");
                int tal = Convert.ToInt32(Console.ReadLine());
                //sum = sum + tal;
                sum += tal;
                i = i + 1;
            }
            Console.WriteLine($"Summan {sum}");
        }


        void Lab5()
        {
            //Skapa ett program där användaren får mata in ett tal. Låt sedan programmet skriva ut
            //    alla siffor som är mindre än det inmatade talet men större än 0.Lös detta med en
            //loop.
            //Console.WriteLine("Mata in ett tal");
            //int tal = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < tal; i++)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("Mata in ett tal");
            int tal = Convert.ToInt32(Console.ReadLine());
            for (int i = tal - 1; i > 0; i--)
            {
                Console.WriteLine(i);
            }

        }




        void Lab2()
        {
            Console.WriteLine("Mata in start");
            int start = Convert.ToInt32(Console.ReadLine());

            //slut måste vara större än start
            int slut = 0;
            while (true)
            {
                Console.WriteLine("Mata in slut");
                slut = Convert.ToInt32(Console.ReadLine());
                if (slut > start)
                {
                    break;
                }
                Console.WriteLine($"MNen din dummer - större än {start} tack!");
            }


            //Skapa ett program som skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            for (int i = start; i <= slut; i++)
            {
                Console.WriteLine(i);
            }
        }

        void Lab2While()
        {
            Console.WriteLine("Mata in start");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in slut");
            int slut = Convert.ToInt32(Console.ReadLine());
            int i = start;
            while (i <= slut)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        void Lab1()
        {


            //Skapa ett program som skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        void Lab1While()
        {
            //Skapa ett program som skriver ut talen 0-10 på skärmen. Lös detta med en for-loop.
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //int i = 0;
            //while (true)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //    if (i > 10)
            //        break;
            //}


        }

        public void Lab7()
        {
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Rolling the dices");
                Console.WriteLine("The values are");
                Console.WriteLine(rnd.Next(1,7));
                Console.WriteLine(rnd.Next(1, 7));
                Console.Write("Roll the dices again? y/n");
                if (Console.ReadLine().ToLower() != "y") break;

            }
        }
    }
}
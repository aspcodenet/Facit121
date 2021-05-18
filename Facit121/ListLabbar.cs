using System;
using System.Collections.Generic;

namespace Facit121
{
    public class ListLabbar
    {
        /*
         * Skapa ett program där användaren får upp fyra frågor om att mata in ett tal. Spara
alla talen i en lista. Loopa igenom lista och ta fram det tal som är störst. Skriv
tillbaka resultatet på skärmen för användaren

         */
        public void Lab1()
        {
            Console.WriteLine("Skriv in hur många tal");
            int antalTal = Convert.ToInt32(Console.ReadLine());
            var talLista = new List<int>();
            for (int i = 0; i < antalTal; i++)
            {
                Console.WriteLine("Skriv in ett tal:");
                talLista.Add(Convert.ToInt32(Console.ReadLine()));
            }

            int oldestSoFar = 0;
            foreach (var tal in talLista)
            {
                if (tal > oldestSoFar)
                    oldestSoFar = tal;
            }
            Console.WriteLine(oldestSoFar);
        }
        public void Run()
        {
            Lab1();
        }
    }
}
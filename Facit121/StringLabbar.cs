using System;

namespace Facit121
{
    public class StringLabbar
    {
        public void Lab1()
        {
            string resultatet = "";
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Mata in en text:");
                string txt = Console.ReadLine();
                resultatet += txt;
            }
            Console.WriteLine(resultatet);
        }

        public void Lab2()
        {
            string s = "HelloWorld,  world";

            //Ta med hjälp av kod ut första förekomsten av bokstaven w
            int pos = s.IndexOf('w');
            //int pos = s.LastIndexOf('l');




            //    Skriv ut vilken position bostaven w har i strängen(H har position 0).
            // Ta fram positionen genom kod.

        }

        public void Run()
        {
            Lab2();
            Lab1();
        }
    }
}
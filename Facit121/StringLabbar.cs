using System;
using System.Linq;

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

        public void Lab7()
        {
            Console.WriteLine("Mata in en text");
            string inmatning = Console.ReadLine();
            string reverse = "";

            //Anna -> annA
            //anna -> anna
            inmatning = inmatning.ToLower();
            inmatning = inmatning.Replace(" ", "");


            foreach (char ch in inmatning)
            {
                reverse = ch + reverse;
            }

            if (reverse == inmatning)
            {
                Console.WriteLine("Detta är en palindrome");
            }
            //"kalle"  -> "lak"

        }

        public void Lab4()
        {
            string s = "Detta är en sträng som du skall ändra";
            s = s.Replace(" ", "*");
            
            int antal = 0;
            foreach (var ch in s)
            {
                if (ch == '*')
                {
                    antal++;
                }
            }
            Console.WriteLine($"Antal: {antal}");

        }

        public void Lab5()
        {
            Console.WriteLine("Mata in en epostadress:");
            string email = Console.ReadLine();

            bool ok = true;
            if (email.Contains("@") == false)
            {
                ok = false;
            }

            int index = email.LastIndexOf('.');
            if (index == -1)
            {
                ok = false;
            }
            else
            {
                if (index < email.Length - 4)
                {
                    ok = false;
                }
            }


        }



        public void Lab3()
        {
            //Håll reda på om nästa char är
            //först i nytt ord
            //Går dock att göra med txtInfo.ToTitleCase
            string namn = "kurt andersson";
            string result = "";
            bool isComingCharFirstInNewWord = true;
            foreach (char ch in namn)
            {
                if (isComingCharFirstInNewWord == true)
                {
                    result += Char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }

                if (ch == ' ')
                {
                    isComingCharFirstInNewWord = true;
                }
                else
                {
                    isComingCharFirstInNewWord = false;
                }
                
            }
        }

        public void Run()
        {
            Lab5();
            Lab3();
            Lab7();
            Lab2();
            Lab1();
        }
    }
}
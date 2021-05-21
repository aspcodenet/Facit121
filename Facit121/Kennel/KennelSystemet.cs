using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Facit121.Kennel
{
    // SUBSTANTIV
    // var meny = new Meny();
    // meny.Draw();

    //I detta demo: INGET JÄKLA  ARV, INGA CONSTRUCTORER ETC ETC

    public class Hund
    {
        public string Namn { get; set; }
        public string Ras { get; set; }
        public int Alder { get; set; }
        public int Vikt { get; set; }

    }
    public class KennelSystemet
    {
        public int GetAnInt()
        {
            while (true)
            {
                string inmatning = Console.ReadLine();
                int resultatet;

                if (int.TryParse(inmatning, out resultatet) == true)
                {
                    return resultatet;
                }
                Console.WriteLine("Mata in ett TAL tack");
            }
        }

        public decimal GetAnDecimal()
        {
            while (true)
            {
                string inmatning = Console.ReadLine();
                decimal resultatet;

                if (decimal.TryParse(inmatning, out resultatet) == true)
                {
                    return resultatet;
                }
                Console.WriteLine("Mata in ett TAL tack");
            }
        }

        public void RitaHuvudMeny()
        {
            Console.WriteLine("1. Registrera");
            Console.WriteLine("2. Lista");
            Console.WriteLine("3. Ta bort");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj...>");
        }

        public string filnamn = @"C:\Users\stefa\Temp\hund.txt";

        public List<Hund> ReadFromFile()
        {
            if (System.IO.File.Exists(filnamn) == false)
                return new List<Hund>();
            return JsonConvert.DeserializeObject<List<Hund>>(File.ReadAllText(filnamn));

        }

        public void WriteToFile(List<Hund> list)
        {
            System.IO.File.WriteAllText(filnamn, JsonConvert.SerializeObject(list) );
        }


        public void Run()
        {
            var list = ReadFromFile();
            while (true)
            {
                RitaHuvudMeny();
                int sel = GetAnInt();
                if (sel == 1)
                {
                    Hund hund = CreateHund();
                    list.Add(hund);
                    WriteToFile(list);
                }
                if (sel == 2)
                {
                    ListaHundar(list);
                }
                if (sel == 3)
                {
                    var hundAttTaBort = ValjHundAttTaBort(list);
                    if (hundAttTaBort != null)
                    {
                        list.Remove(hundAttTaBort);
                        WriteToFile(list);
                    }
                }

                if (sel == 4)
                {
                    return;
                }
            }
        }

        public Hund ValjHundAttTaBort(List<Hund> list)
        {
            Console.Clear();
            Console.WriteLine("Ange namn på hund att ta bort:");
            string namn = Console.ReadLine();
            foreach (var h in list)
            {
                if (h.Namn == namn)
                {
                    return h;
                }
            }

            return null;
        }

        public void ListaHundar(List<Hund> list)
        {
            Console.Clear();
            Console.Write("Mata in minsta svanslängd:");
            decimal minLength = GetAnDecimal();
            foreach (var hund in list)
            {
                decimal svansLangd = Convert.ToDecimal(hund.Alder) *
                                     Convert.ToDecimal(hund.Vikt) / Convert.ToDecimal(10);
                if (hund.Ras.ToLower() == "tax") //Tax  TAX tAx  yes   Yes
                {
                    svansLangd = 3.7m;
                }
                if(svansLangd > minLength)
                {
                    Console.WriteLine($"{hund.Namn} {hund.Alder} {hund.Ras} {hund.Vikt}");
                }
            }
        }

        public Hund CreateHund()
        {
            var hund = new Hund();
            Console.Clear();
            Console.Write("Mata in namn:");
            hund.Namn = Console.ReadLine();
            Console.Write("Mata in ras:");
            hund.Ras = Console.ReadLine();
            Console.Write("Mata in ålder:");
            hund.Alder =  GetAnInt();
            Console.Write("Mata in Vikt:");
            hund.Vikt = GetAnInt();
            return hund;

        }

    }
}
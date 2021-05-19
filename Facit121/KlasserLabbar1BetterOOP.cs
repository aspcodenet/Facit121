using System;
using System.Collections.Generic;

namespace Facit121
{
    public enum MatTypBetter
    {
        None,
        Kott,
        Vegan,
        Vegetarisk
    }


    public class MatrattBetter
    {
        public string Namn { get; set; }
        public decimal Pris { private get; set; }
        public MatTypBetter Typ { get; set; }
        public int AntalKalorier { get; set; }

        public MatrattBetter(string namn, decimal pris, MatTypBetter typ, int antalKalorier)
        {
            Namn = namn;
            Pris = pris;
            Typ = typ;
            AntalKalorier = antalKalorier;
        }

        public decimal GetPrice()
        {
            if (Typ == MatTypBetter.Vegetarisk && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Pris * 0.8m;
            }

            return Pris;
        }
    }

    public class KlasserLabbar1Better
    {
        public void Run()
        {
            var listan = new List<MatrattBetter>();

            var m = new MatrattBetter("Pannkakor", 100, MatTypBetter.Vegetarisk, 101);
            listan.Add(m);

            m = new MatrattBetter("Köttbullar", 98, MatTypBetter.Kott, 100);
            listan.Add(m);

            m = new MatrattBetter("Hamburgare", 95, MatTypBetter.Kott, 30);
            listan.Add(m);


            Console.WriteLine("*** DAGENS LUNCH ***");

            Console.WriteLine("*** Vegetariska ***");
            foreach (var mat in listan)
            {
                if (mat.Typ == MatTypBetter.Vegetarisk)
                {
                    Console.WriteLine($"{mat.Namn} {mat.GetPrice()} {mat.AntalKalorier}");
                }
            }

            Console.WriteLine("*** Kött ***");
            foreach (var mat in listan)
            {
                if (mat.Typ == MatTypBetter.Kott)
                {
                    Console.WriteLine($"{mat.Namn} {mat.GetPrice()} {mat.AntalKalorier}");
                }
            }

        }
    }


}
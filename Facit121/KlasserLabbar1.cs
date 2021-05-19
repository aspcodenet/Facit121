using System;
using System.Collections.Generic;

namespace Facit121
{
    public enum MatTyp
    {
        None,
        Kott,
        Vegan,
        Vegetarisk
    }


    public enum PlayerPosition
    {
        Goalie,
        Defence,
        Forward
    }


    public class Matratt
    {
        public string Namn { get; set; }
        public decimal Pris { get; set; }
        public MatTyp Typ { get; set; }
        public int AntalKalorier { get; set; }

        public decimal GetPrice()
        {
            if (Typ == MatTyp.Vegetarisk && DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Pris * 0.8m;
            }

            return Pris;
        }
    }

    public class KlasserLabbar1
    {
        public void Run()
        {
            var listan = new List<Matratt>();
            listan.Add(new Matratt
            {
                AntalKalorier = 101,
                Namn = "Pannkakor",
                Pris = 100,
                Typ = MatTyp.Vegetarisk
            });
            listan.Add(new Matratt
            {
                AntalKalorier = 100,
                Namn = "Köttbullar",
                Pris = 98,
                Typ = MatTyp.Kott
            });
            listan.Add(new Matratt
            {
                AntalKalorier = 30,
                Namn = "Hamburgare",
                Pris = 55,
                Typ = MatTyp.Kott
            });

            Console.WriteLine("*** DAGENS LUNCH ***");

            Console.WriteLine("*** Vegetariska ***");
            foreach (var mat in listan)
            {
                if (mat.Typ == MatTyp.Vegetarisk)
                {
                    Console.WriteLine($"{mat.Namn} {mat.GetPrice()} {mat.AntalKalorier}");
                }
            }

            Console.WriteLine("*** Kött ***");
            foreach (var mat in listan)
            {
                if (mat.Typ == MatTyp.Kott)
                {
                    Console.WriteLine($"{mat.Namn} {mat.GetPrice()} {mat.AntalKalorier}");
                }
            }

        }
    }
}
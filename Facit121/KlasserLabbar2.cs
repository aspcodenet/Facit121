using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Facit121
{
    public class Person
    {
        public Person(DateTime birthDate, string namn )
        {
            BirthDate = birthDate;
            Namn = namn;
        }

        public void BytAddress(string gatuadress, int postnr, string postort)
        {
            Gatuadress = gatuadress;
            Postnr = postnr;
            Postort = postort;
        }
        public DateTime BirthDate { get; set; }
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public int Postnr { get; private set; }
        public string Postort { get; private set; }
    }
    public class KlasserLabbar2
    {
        public void Run()
        {
            var stefan = new Person(new DateTime(1972,8,3), "Stefan");

            stefan.Namn = "312123";

            //Meny
            //1. Byt address
            stefan.BytAddress("Testgatan 123",12233,"Teststad");


        }
    }
}
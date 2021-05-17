using System.Drawing;

namespace Facit121
{
    public class Hus
    {
        public string Color { get; set; } //5000
        public string GatuAddress { get; set; }

        public void Repaint(string color)
        {
            Color = color;
            RenoveringsKostnad += 5000;
        }

        public void InstallJacuzzi()
        {
            Jacuzzi = true;
            RenoveringsKostnad += 10000;
        }
        public bool Jacuzzi { get; set; } //10000
        public int RenoveringsKostnad { get; set; }
    }

    public class Demos20210517
    {
        public void Run()
        {
            int minAge = 48;
            int syrransAge = 50;

            var mittHus = new Hus();
            mittHus.Color = "Vitt";
            mittHus.GatuAddress = "Testgatan 1";

            var syrransHus = new Hus();
            syrransHus.Color = "Vitt";
            syrransHus.GatuAddress = "Testgatan 2";
            syrransHus.Repaint("Red");
            mittHus.InstallJacuzzi();
            //OOP...
        }
    }
}
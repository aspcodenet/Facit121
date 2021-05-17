using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Facit121
{
    public class Demos
    {
        public void RitaHuvudmeny()
        {
            Console.WriteLine("1. Lista alla");
            Console.WriteLine("2. Skapa ny");
            Console.WriteLine("3. Exit");
        }

        public void PrintAllPlayers(List<HockeyPlayer> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"{player.JerseyNumber} {player.Name}");
            }
        }

        public HockeyPlayer CreateNewPlayer()
        {
            Console.WriteLine("Ange namn:");
            string namn = Console.ReadLine();
            Console.WriteLine("Ange tröjnumber:");
            int jersey = Convert.ToInt32(Console.ReadLine());
            HockeyPlayer player = new HockeyPlayer { JerseyNumber = jersey, Name = namn };
            return player;

        }

        public void Run()
        {


            List<HockeyPlayer> players = new List<HockeyPlayer>();



            players.Add(new HockeyPlayer { JerseyNumber = 21, Name = "Foppa" });
            players.Add(new HockeyPlayer { JerseyNumber = 13, Name = "Sudden" });
            var p = new HockeyPlayer {JerseyNumber = 19, Name = "Bäckis"};
            p.TeamNames.Add("Brynäs");
            p.TeamNames.Add("Washington Capitals");
            p.TeamNames.Add("Dynamo Moskva");
            players.Add(p);


            while (true)
            {
                RitaHuvudmeny();
                Console.Write("Välj:>");
                int sel = Convert.ToInt32(Console.ReadLine());
                if (sel == 1)
                {
                    PrintAllPlayers(players);
                }
                if (sel == 2)
                {
                    HockeyPlayer player =  CreateNewPlayer();
                    players.Add(player);
                }
                if (sel == 3)
                {
                    break;
                }
            }

            //var foppa = new HockeyPlayer { JerseyNumber  = 21, Name = "Foppa"};
            //var backis = new HockeyPlayer { JerseyNumber = 19, Name = "Bäckis" };
            //var sudden = new HockeyPlayer { JerseyNumber = 13, Name = "Sudden" };


            //List<DateTime> birthDates = new List<DateTime>();
            List<string> minaBarn = new List<string>();
            minaBarn.Add("Fanny");
            minaBarn.Add("Josefine");
            minaBarn.Add("Oliver");


            foreach (var namn in minaBarn)
            {
                Console.WriteLine(namn);
            }
            
            //string barn1 = "Fanny";
            //string barn2 = "Josefine";
            //string barn3 = "Oliver";

        }
    }
}
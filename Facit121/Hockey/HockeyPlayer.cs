using System;
using System.Collections.Generic;
using System.Text;

namespace Facit121.Hockey
{
    public class HockeyPlayer
    {
        public HockeyPlayer() // CONSTRUCTOR!
        {
            TeamNames = new List<string>();
        }
        public List<string> TeamNames { get; set; }
        public string Name { get; set; } 
        public int JerseyNumber { get; set; }
    }
}

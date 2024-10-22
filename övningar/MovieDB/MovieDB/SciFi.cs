using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    internal class SciFi : Movie
    {
        public int NumberOfSpaceShips { get; set; }

        public SciFi(string title, int runningTime, List<Actor> actors, int numberOfSpaceShips) : base(title, runningTime, actors)
        {
            NumberOfSpaceShips = numberOfSpaceShips;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Filmen innehåller minst " + NumberOfSpaceShips + " rymdskepp.");
        }
    }
}

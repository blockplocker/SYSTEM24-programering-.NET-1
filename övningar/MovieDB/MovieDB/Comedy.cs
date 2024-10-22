using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    internal class Comedy : Movie
    {
        public int NumberOfFunnyScenes { get; set; }

        public Comedy(string title, int runningTime, List<Actor> actors, int numberOfFunnyScenes) : base(title, runningTime, actors)
        {
            NumberOfFunnyScenes = numberOfFunnyScenes;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Filmen innehåller " + NumberOfFunnyScenes + " roliga scener.");
        }
    }
}

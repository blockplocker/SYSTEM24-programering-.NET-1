using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    internal class Action : Movie
    {
        public int NumberOfShotsFired { get; set; }

        public Action(string title, int runningTime, List<Actor> actors, int numberOfShotsFired) : base(title, runningTime, actors)
        {
            NumberOfShotsFired = numberOfShotsFired;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("I filmen skjuts det " + NumberOfShotsFired + " gånger.");
        }
    }
}

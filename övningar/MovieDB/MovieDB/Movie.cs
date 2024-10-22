using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    internal class Movie
    {
        public string Title { get; set; }
        public int RunningTime { get; set; }
        public List<Actor> Actors { get; set; }

        public Movie(string title, int runningTime, List<Actor> actors)
        {
            Title = title;
            RunningTime = runningTime;
            Actors = actors;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine("Filmen " + Title + " är " + RunningTime + " min lång, och har följande skådespelare: ");
            foreach (Actor actor in Actors)
            {
                Console.Write(actor.Name + " (" + actor.BirthYear + "),");
            }
        }
    }
}

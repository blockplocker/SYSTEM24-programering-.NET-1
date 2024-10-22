using System.Text;

namespace MovieDB
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();
            List<Actor> actors = new List<Actor>();

            actors.Add(new Actor("Tom Cruise", 1970));
            actors.Add(new Actor("Arnold Schwarzenegger", 1955));
            movies.Add(new Comedy("The Lost City", 125, actors, 23));

            movies.Add(new Comedy("Murder Mystery", 119, actors, 12));
            movies.Add(new Action("The Continental", 112, actors, 97));
            movies.Add(new Action("Mission Impossible", 134, actors, 245));
            movies.Add(new SciFi("The Creator", 142, actors, 12));
            movies.Add(new SciFi("Dune", 153, actors, 9));

            foreach (Movie movie in movies)
            {
                movie.PrintInfo();
            }

            Console.WriteLine("-----------------------------------------------------");


            foreach (Movie movie in movies)
            {
                Console.WriteLine("Filmen " + movie.Title + " är " + movie.RunningTime + " min lång, och har följande skådespelare: ");
                foreach (Actor actor in movie.Actors)
                {
                    Console.Write(actor.Name + " (" + actor.BirthYear + "),");
                }
                if (movie is Comedy)
                {
                    Console.WriteLine("Filmen innehåller " + ((Comedy)movie).NumberOfFunnyScenes + " roliga scener.");
                }
                else if (movie is Action)
                {
                    Console.WriteLine("I filmen skjuts det " + ((Action)movie).NumberOfShotsFired + " gånger.");
                }
                else if (movie is SciFi)
                {
                    Console.WriteLine("Filmen innehåller minst " + ((SciFi)movie).NumberOfSpaceShips + " rymdskepp.");
                }
            }
        }
    }
}

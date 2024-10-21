namespace Skogen_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Animal> forrest = new List<Animal>();
            forrest.Add(new Owl(20, true, 185));
            forrest.Add(new Horse(300, false, 10));
            forrest.Add(new Dolfin(100, false, 100));

            bool day = true;
            while (true)
            {
                Console.Write("Dag(d) Natt(n): ");
                string input = Console.ReadKey().KeyChar.ToString();
                day = (input == "d" ? true : (input == "n" ? false : day));
                Console.WriteLine();

                foreach (Animal animal in forrest)
                {
                    Console.WriteLine(animal.GetType().Name + " " + animal.Weight + " kg " + (animal.Nocturnal ? " nattdjur " : "dagdjur"));
                    if (animal is Owl)
                    {
                        Console.WriteLine("Ugglan har en vingbrädd på " + ((Owl)animal).Wingspan + " cm");
                    }
                    else if (animal is Horse)
                    {
                        Console.WriteLine("Hästen äter " + ((Horse)animal).HayPerDay + " kg hö per dag");
                    }
                    else if (animal is Dolfin)
                    {
                        Console.WriteLine("Dolfin simmar " + ((Dolfin)animal).DistancePerDay + " km per dag");
                    }
                    else
                    {
                        Console.WriteLine("Okänt djur");
                    }


                    animal.Move(day);
                }

            }
        }
    }
}

namespace Skogen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> forest = new List<Animal>();
            forest.Add(new Animal("Varg", true, "smyger omkring", "letar efter byte"));
            forest.Add(new Animal("Fladdermus", true, "flyger runt bland träden", "jagar insekter"));
            forest.Add(new Animal("Älg", false, "springer runt i skogen", "betar"));
            forest.Add(new Animal("Räv", true, "smyger omkring", "letar efter mat"));
            forest.Add(new Animal("Uggla", true, "flyger", "jagar smådjur"));
            forest.Add(new Animal("Rådjur", false, "springer runt i skogen", "betar"));
            forest.Add(new Animal("Ekorre", false, "klättrar i träd", "samlar nötter"));
            forest.Add(new Animal("Hare", false, "hoppar runt", "äter gräs"));
            forest.Add(new Animal("Örn", false, "flyger", "spanar efter byte"));

            while (true)
            {
                Console.WriteLine("dag(d) eller natt(n)");
                char time = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (time == 'd')
                {
                    foreach (var animal in forest)
                    {
                        Animal.AnimalDoing(animal, false);
                    }
                }
                else if (time == 'n')
                {
                    foreach (var animal in forest)
                    {
                        Animal.AnimalDoing(animal, true);
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning");
                }
            }
        }
    }
}

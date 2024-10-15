namespace Skogen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Animal> forest = new List<Animal>();
            forest.Add(new Animal("Varg", true, "springer"));
            forest.Add(new Animal("Fladdermus", true, "flyger"));
            forest.Add(new Animal("Älg", false, "springer"));
            forest.Add(new Animal("Räv", true, "springer"));
            forest.Add(new Animal("Uggla", true, "flyger"));
            forest.Add(new Animal("Rådjur", false, "springer"));
            forest.Add(new Animal("Ekorre", false, "springer"));
            forest.Add(new Animal("Hare", false, "springer"));


        }
    }
}

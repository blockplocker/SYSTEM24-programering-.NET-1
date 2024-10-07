using System.Threading.Channels;

namespace hotell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] hotell =
            {
                {"Tomt","Tomt","Tomt","Tomt"},
                {"Tomt","Tomt","Tomt","Tomt"},
                {"Tomt","Tomt","Tomt","Tomt"}
            };

            
            while (true)
            {
                string myString = "";
                string[] hotel = myString.Split('|');


                Console.WriteLine("Våning 1: 650 kr/rum rum 1-4");
                Console.WriteLine("Våning 2: 775 kr/rum rum 5-8");
                Console.WriteLine("Våning 3: 995 kr/rum rum 9-12");

                Console.WriteLine("vad heter du");
                string name = Console.ReadLine();

                Console.WriteLine("vilket rum vill du bo i");
                int.TryParse(Console.ReadLine(), out int bokning);

                int rum = 1;
                for (int row = 0; row < hotell.GetLength(0); row++)
                {
                    for (int col = 0; col < hotell.GetLength(1); col++)
                    {
                        rum = 4 * row + col + 1;
                        if (rum == bokning)
                        {
                            hotell[row, col] = $"{rum}: {name}";
                        }
                        Console.Write($"{rum}: {hotell[row, col]} \t");

                    }
                    Console.WriteLine();
                }
            }
            

        }
    }
}

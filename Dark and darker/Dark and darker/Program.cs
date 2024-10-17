namespace Dark_and_darker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Main Menu ---");
                Console.WriteLine("1. Calculate Druid Damage");
                Console.WriteLine("2. Other Method (Placeholder)");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "3")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Druid.calculateDamage();
                        break;
                    case "2":
                        // Placeholder for other methods
                        Console.WriteLine("Other method not implemented yet.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }

}

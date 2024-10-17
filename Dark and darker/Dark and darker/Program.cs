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
                Console.WriteLine("2. Calculate Druid health");
                Console.WriteLine("3. Other Method (Placeholder)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "4")
                {
                    break;
                }

                switch (choice)
                {
                    case "1":
                        Druid.calculateDamage();
                        break;
                    case "2":
                        Druid.calculateHP();
                        break;
                    case "3":
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

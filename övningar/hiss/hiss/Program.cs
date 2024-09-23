namespace hiss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentFloor = 0;

            while (true)
            {
                Console.WriteLine("Vilken våning vill du åka till? (0-4)");

                ConsoleKeyInfo key = Console.ReadKey();
                int targetFloor = key.KeyChar - '0';

                if (targetFloor >= 0 && targetFloor <= 4)
                {
                    int floorsToTravel = Math.Abs(targetFloor - currentFloor);
                    Console.Clear();
                    Console.WriteLine($"Åker till våning {targetFloor}... det tar {floorsToTravel} sekunder");
                    Thread.Sleep(floorsToTravel * 1000); 

                    switch (targetFloor)
                    {
                        case 0:
                            Console.WriteLine("våning 0: Entrèplan");
                            break;
                        case 1:
                            Console.WriteLine("våning 1: Säljavdelningen");
                            break;
                        case 2:
                            Console.WriteLine("våning 2: IT - avdelningen");
                            break;
                        case 3:
                            Console.WriteLine("våning 3: Projekt - ledningen");
                            break;
                        case 4:
                            Console.WriteLine("våning 4: Chefen");
                            break;
                    }

                    currentFloor = targetFloor;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ogiltig våning. Försök igen.");
                }
            }
        }
    }
}

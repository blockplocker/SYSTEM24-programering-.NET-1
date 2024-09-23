namespace bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int konto = 0;


            while (true)
            {
                showMenu();

                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'i':
                    case 'I':
                        Console.WriteLine("Insättning");
                        Console.WriteLine("----------");
                        konto = insättnig(konto);
                        break;
                    case 'u':
                    case 'U':
                        Console.WriteLine("Uttag");
                        Console.WriteLine("-----");
                        konto = uttag(konto);
                        break;
                    case 's':
                    case 'S':
                        Console.Clear();
                        Console.WriteLine("Saldo");
                        Console.WriteLine("-----");
                        saldo(konto);
                        break;
                    case 'a':
                    case 'A':
                        return;
                }
            }
            static void showMenu()
            {
                Console.WriteLine("[I]nsättning");
                Console.WriteLine("[U]ttag");
                Console.WriteLine("[S]aldo");
                Console.WriteLine("[A]vsluta");
            }

            static int insättnig(int konto)
            {
                while (true)
                {
                    Console.WriteLine("Hur mycket vill du sätta in?");
                    if (int.TryParse(Console.ReadLine(), out int insättning))
                    {
                        if (insättning < 0||insättning > 10000)
                        {
                            Console.WriteLine("Felaktig inmatning du kan bara sätta in mellan 1 - 10 000kr");
                        }
                        else
                        {
                        Console.Clear();
                        return konto += insättning;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning");
                    }
                }
            }

            static int uttag(int konto)
            {
                while (true)
                {
                    Console.WriteLine("Hur mycket pengar vill du ta ut?");
                    if (int.TryParse(Console.ReadLine(), out int uttag))
                    {
                        Console.Clear();
                        if (uttag > konto)
                        {
                            Console.WriteLine($"Du har inte tillräckligt med pengar på kontot");
                            return konto;
                        }
                        else
                        {
                        return konto -= uttag;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Felaktig inmatning");

                    }
                }
            }

            static void saldo(int konto)
            {
                Console.WriteLine($"Ditt saldo är {konto} kr");
            }



        }
    }
}

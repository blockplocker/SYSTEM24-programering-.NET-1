namespace labyrinten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int.TryParse(Console.ReadLine(), out int size);
            int size = 3;
            int characterX = 0;
            int characterY = 0;
            int tresureX = 1;
            int tresureY = 1;
            int score = 0;

            while (true)
            {
                if (characterX == tresureX && characterY == tresureY)
                {
                    score++;
                    tresureX = new Random().Next(0, size);
                    tresureY = new Random().Next(0, size);
                }
                displayGame(size, characterX, characterY, tresureX, tresureY);
                    Console.WriteLine("Score: " + score);

                ConsoleKeyInfo key = Console.ReadKey();
                switch (key.KeyChar)
                {
                    case 'w':
                        if (characterY - 1 > -1)
                        {
                            characterY--;
                        }
                        break;
                    case 's':
                        if (characterY + 1 < size)
                        {
                            characterY++;
                        }
                        break;
                    case 'a':
                        if (characterX - 1 > -1)
                        {
                            characterX--;
                        }
                        break;
                    case 'd':
                        if (characterX + 1 < size)
                        {
                            characterX++;
                        }
                        break;
                    case 'x':
                        size++;
                        break;
                    case 'z':
                        size--;
                        break;
                    case 'q':
                        return;
                }
            }

            void displayGame(int size, int characterX, int characterY, int tresureX, int tresureY)
            {
                Console.Clear();
                Console.WriteLine("bigger(x) smaller(z) quit(q) WASD to move");

                roof(size);
                for (int row = 0; row < size; row++)
                {
                    wall(size);
                    Console.WriteLine();
                    wall(size, row, characterX, characterY, tresureX, tresureY);
                    Console.WriteLine();
                    wall(size);
                    roof(size);
                }
            }

            void wall(int size, int row = -1, int characterX = -1, int characterY = -1, int tresureX = -1, int tresureY = -1)
            {
                Console.Write("|");
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i == characterX && row == characterY && j == 1)
                        {
                            Console.Write("&");
                        }
                        else if (i == tresureX && row == tresureY && j == 1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.Write("|");
                }
            }

            void roof(int size)
            {
                Console.WriteLine();
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("-");
                    }
                }
                Console.Write("-");
                Console.WriteLine();
            }
        }
    }
}

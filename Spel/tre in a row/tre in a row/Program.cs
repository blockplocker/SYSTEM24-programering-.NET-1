using System.Security.Cryptography.X509Certificates;

namespace tre_in_a_row
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to three in a row!");
            Console.WriteLine("Choose x or o:");
            string player1 = Console.ReadLine();

            string player2 = (player1 == "x") ? "o" : "x";
            string currentPlayer = player1;



            string[,] gameBoard = { { "-", "-", "-" }, { "-", "-", "-" }, { "-", "-", "-" } };

            void displayGame()
            {
                Console.WriteLine($"  1 2 3");
                Console.WriteLine($"a {gameBoard[0, 0]} {gameBoard[0, 1]} {gameBoard[0, 2]}");
                Console.WriteLine($"b {gameBoard[1, 0]} {gameBoard[1, 1]} {gameBoard[1, 2]}");
                Console.WriteLine($"c {gameBoard[2, 0]} {gameBoard[2, 1]} {gameBoard[2, 2]}");
            }
            void resetGame()
            {
                for ( int i = 0; i < 3; i++)
                {
                    for ( int j = 0; j < 3; j++ )
                    {
                        gameBoard[i,j] = "-";
                    }
                }
                currentPlayer = player1;
                //Console.WriteLine("Choose x or o:");
                //player1 = Console.ReadLine();
                //player2 = (player1 == "x") ? "o" : "x";
            }

            bool checkIfYouWon()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (gameBoard[i, 0] == currentPlayer && gameBoard[i, 1] == currentPlayer && gameBoard[i, 2] == currentPlayer)
                    {
                        return true;
                    }
                    else if (gameBoard[0, i] == currentPlayer && gameBoard[1, i] == currentPlayer && gameBoard[2, i] == currentPlayer)
                    {
                        return true;
                    }
                }
                if (gameBoard[0, 0] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 2] == currentPlayer)
                {
                    return true;
                }
                else if (gameBoard[0, 2] == currentPlayer && gameBoard[1, 1] == currentPlayer && gameBoard[2, 0] == currentPlayer)
                {
                    return true;
                }
                return false;
            }
            bool isBoardFull()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (gameBoard[i, j] == "-")
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            while (true)
            {
                displayGame();
                string place = Console.ReadLine().ToLower();

                if (place.Length != 2)
                {
                    Console.WriteLine("Invalid input. Please enter a valid move like 'a1' or 'b2'.");
                    continue;
                }
                
                int[] index = { placeToIndex(place[0]), place[1] - '1' };

                if (index[0] >= 0 && index[0] < 3 && index[1] >= 0 && index[1] < 3)
                {
                    if (gameBoard[index[0], index[1]] == "-")
                    {
                        gameBoard[index[0], index[1]] = currentPlayer;
                        if (checkIfYouWon())
                        {
                            Console.Clear();
                            displayGame();
                            Console.WriteLine($"{currentPlayer} won!! press(g) to play again");
                            string restart = Console.ReadLine();
                            if (restart == "g")
                            {
                                resetGame();
                            }
                        }
                        else if(isBoardFull()){
                            Console.WriteLine("Draw!! press(g) to play again");
                            string restart = Console.ReadLine();
                            if (restart == "g")
                            {
                                resetGame();
                            }
                        }
                        else
                        {
                        currentPlayer = (currentPlayer == player1) ? player2 : player1;
                        Console.Clear();

                        }
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move. Please try again.");
                }

            }

            static int placeToIndex(char place)
            {
                switch (place)
                {
                    case 'a':
                        return 0;
                    case 'b':
                        return 1;
                    case 'c':
                        return 2;
                    default:
                        return -1;
                }
            }



        }
    }
}

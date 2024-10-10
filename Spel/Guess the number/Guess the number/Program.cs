namespace Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1000) + 1;
            int guess = 0;
            int max = 1000;
            int min = 1;
            int score = 100;
            int bestscore = 0;

            bool game = true;

            while (game)
            {

                Console.WriteLine($"Nummret är mellan {min} och {max}");
                Console.WriteLine("Hej din lilla busunge gissa numret: ");
                guess = int.Parse(Console.ReadLine());


                if (guess == number)
                {
                    if (score > bestscore)
                    {
                        bestscore = score;
                    }
                    Console.WriteLine($"You won YAY!!! your score was {score} your all time best score was {bestscore}");
                    Console.WriteLine("Play agin press(g)");
                    string restart = Console.ReadLine();
                    if (restart == "g")
                    {
                        number = random.Next(1000) + 1;
                        max = 1000;
                        min = 1;
                        guess = 0;
                        score = 100;
                    }
                }
                else if (guess > number)
                {
                    max = guess;
                }
                else if (guess < number)
                {
                    min = guess;
                }
                else
                {
                    Console.WriteLine(" You did the impossible your guess was not the number and it was not bigger or smaller :()");
                }
                score -= 10;
            }
        }
    }
}

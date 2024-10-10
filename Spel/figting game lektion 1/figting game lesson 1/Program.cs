

Console.WriteLine("Welcome to the Fighting game!");
Console.WriteLine("Enter your Name:");
string name = Console.ReadLine();
Console.WriteLine("Hi " + name);

string oponent = "lars";
int playerHp = 100;
int enemyHp = 100;

int restart = 1;

Console.WriteLine($"Your opponent is {oponent} and he has {enemyHp} HP");
Random random = new Random();

int kick = 10; //20;
int block = 5; //10;


while (restart > 0)
{
    Console.WriteLine($"{name} has {playerHp} HP and {oponent} has {enemyHp} HP");
    Console.WriteLine("Choose your move: block(b) or kick(k):");
    string move = Console.ReadLine();

    if (move == "k")
    {
        enemyHp -= kick + random.Next(10);
        Console.WriteLine($"{oponent} now has {enemyHp} HP");
    }
    else if (move == "b")
    {
        playerHp += block + random.Next(10);
        Console.WriteLine($"{name} healed for 10 and now have {playerHp} HP");
    }
    else
    {
        Console.WriteLine($"You chose a move that doesn't exist: {move}");
    }

    int attack = random.Next(2);
    if (attack == 0)
    {
        playerHp -= kick + random.Next(10);
        Console.WriteLine($"{oponent} chose kick. You have {playerHp} HP");
    }
    else
    {
        enemyHp += block + random.Next(10);
        Console.WriteLine($"{oponent} healed and now has {enemyHp} HP");
    }


    if (enemyHp < 1 || playerHp < 1)
    {
        if (enemyHp < 1)
        {
            Console.WriteLine(" ");
            Console.WriteLine("you won :)");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine(" ");
            Console.WriteLine("you Lost :(");
            Console.WriteLine(" ");
        }
        Console.WriteLine("do you want to play agin yes(y) no(n):");
        string choise = Console.ReadLine();
        if (choise == "y")
        {
            playerHp = 100;
            enemyHp = 100;
            Console.WriteLine($"Your opponent is {oponent} and he has {enemyHp} HP");
        }
        else
        {
            restart = 0;
        }
    }
}

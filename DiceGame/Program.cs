int playerRandomNum;
int computerRandomNum;
int playerPoints = 0;
int computerPoints = 0;

var random = new Random();

for (int i = 0; i < 10; i++)
{
    Console.Write("Press any key to roll the dice.");
    Console.ReadKey();

    playerRandomNum = random.Next(1, 7);
    Console.WriteLine($"You have rolled {playerRandomNum}");

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    computerRandomNum = random.Next(1, 7);
    Console.WriteLine($"The computer has rolled {computerRandomNum}");

    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    if (playerRandomNum > computerRandomNum)
    {
        playerPoints++;
        Console.WriteLine("You have won this round.");
    } else if (computerRandomNum > playerRandomNum)
    {
        computerPoints++;
        Console.WriteLine("The computer has won this round.");
    } else
    {
        Console.WriteLine("It's a draw.");
    }
}

Console.WriteLine("===========================");
Console.WriteLine("========= RESULT ==========");
Console.WriteLine("===========================");

if (playerPoints > computerPoints)
{
    Console.WriteLine("You have won the game!");
} else if (computerPoints > playerPoints) {
    Console.WriteLine("The computer has won the game :/");
} else
{
    Console.WriteLine("It's a draw game.");
}

Console.Write("Press any key to exit the game.");
Console.ReadKey();



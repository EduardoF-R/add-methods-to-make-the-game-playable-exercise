Random random = new Random();
var target = 0;
var roll = 0;

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

bool ShouldPlay()
{
    string? input = Console.ReadLine()?.ToUpper();
    return input == "Y";
}

string WinOrLose()
{
    return roll <= target ? "You lose." : "You win!";
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        target = random.Next(1, 6);
        roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

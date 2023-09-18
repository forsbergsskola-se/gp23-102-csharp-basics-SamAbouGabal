int matches = 24;
bool userTurn = true;
Console.WriteLine(@"Hello and welcome to the game of NIM!
The game starts with 24 matches. You can remove 1,2 or 3 matches per turn.
The one who draws the last match loose");
while (matches > 0)
{
    Console.WriteLine($"\n Matches left: {new string('|', matches)} ({matches})");
    if (userTurn)
    {
        int userChoise;
        Console.WriteLine("Your turn. Remove 1-3 matches");
        UserInputAgain:
        if (!int.TryParse(Console.ReadLine(), out userChoise) || userChoise < 1 || userChoise > 3 || userChoise > matches)
        {
            Console.WriteLine("Invalid input. Input a number between 1-3");
            goto UserInputAgain;
        }

        matches -= userChoise;
        Console.WriteLine($"You removed {userChoise} matches.");
    }
    else
    {
        int aiChoice = Math.Min(matches, Random.Shared.Next(1, 4));
        matches -= aiChoice;
        Console.WriteLine($"The game removed {aiChoice} matches.");
    }

    userTurn = !userTurn;
}

if (userTurn)
{
    Console.WriteLine("Congratulations you win!");
}
else
{
    Console.WriteLine("Unfortunately the ai wins. You lost \nThanks for playing");
}
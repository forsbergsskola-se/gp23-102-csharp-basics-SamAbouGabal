/*
 PSEUDOCODE:
// Random random = new Random();
int myRandom = random.Next (1,100);//
myNumber := random number between 1 and 100

//Console.WriteLine(@"Welcome to guess my number game!
I will ask you for a number between 1-100.
If you guess the right number you win!
Otherwise i will give you a clue if my number is Higher or Lower.
Sounds good? Let's go");//
explain rules to user

//Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");//
USER_TURN:
ask user for number

//int userInput = int.Parse(Console.ReadLine());//
guess := user input

//else if (userInput > myRandom)
{
    Console.WriteLine("Nope! My number is Smaller!");
}//
if myNumber is less than guess then
tell user to guess lower
    go back to USER_TURN
    end if

if myNumber is greater than guess then
tell user to guess higher
    go back to USER_TURN
    end if

if myNumber is equal to guess then
tell user he won
end if
*/




/*
int attempts = 0;
while(attempts < 10);
if (attempts >10)
*/

using System.Threading.Channels;

Random random = new Random();
int myRandom = random.Next (1,100);
Console.WriteLine(@"Welcome to guess my number game!
I will ask you for a number between 1-100.
If you guess the right number you win!
Otherwise i will give you a clue if my number is Higher or Lower.
Sounds good? Let's go");
int attempts = 10;
Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");
nextTurn:

int userInput = int.Parse(Console.ReadLine());
if (myRandom == userInput)
{
        Console.WriteLine("That's the number! Well played!");
        
}
else if (attempts <= 1)
    {
            Console.WriteLine($"You've run out of guesses. GAME OVER. The correct answer is : {myRandom}");
    }

else
    {
        string answer = userInput < myRandom && (attempts > 1) ? "Greater" : "smaller";
        Console.WriteLine($"Nope! My number is {answer}! You have {--attempts} left");
        goto nextTurn;

    }
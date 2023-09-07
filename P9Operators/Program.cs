/* Exercise 1

Console.WriteLine("welcome to km/h to m/h converter");
Console.WriteLine("Please enter a value in km/h");
string userInput = Console.ReadLine();
float userNumber = float.Parse(userInput);
float x = userNumber * 1000 / 60 / 60;
Console.WriteLine($"That would be {x} m/s");
*/

/* Exercise 2 (Implement a program that takes an integer input for minutes and displays the result in seconds.)

 
Console.WriteLine("Minute to second converter");
Console.WriteLine("Type in the wanted amount of minutes");
string userInput = Console.ReadLine();
int userMinutes = int.Parse(userInput);
int x = userMinutes * 60;
Console.WriteLine($"That would be {x} seconds");
*/

/* Exercise 3 (Implement a program that takes an input for km/h and displays the result in m/s.)
 
Console.WriteLine("km/h to m/s converter");
Console.WriteLine("type in the wanted amount of km/h");
string userInput = Console.ReadLine();
float userKm = float.Parse(userInput);
float x = userKm / 3600 * 1000;
Console.WriteLine($"{x} is the m/s of {userInput}");
*/

/* Exercise 4 (Implement a program that takes two integers as input and displays their division result as a float.)
 
Console.WriteLine("Give me an equation to divide");
Console.WriteLine("Type in first number: ");
string userInputX = Console.ReadLine();
int x = Convert.ToInt32(userInputX);
Console.WriteLine("Type in second number");
string userInputY = Console.ReadLine();
int y = Convert.ToInt32(userInputY);
float answer = (float)x / y;
Console.WriteLine($"{userInputX} divided by {userInputY} = {answer}");
*/

/* Exercise 5 (Write a program that calculates the remainder of dividing two integers and displays the result.)
Console.WriteLine("Give me an equation to divide");
Console.WriteLine("Type in first number: ");
string userInputX = Console.ReadLine();
int x = Convert.ToInt32(userInputX);
Console.WriteLine("Type in second number");
string userInputY = Console.ReadLine();
int y = Convert.ToInt32(userInputY);
int mod = x % y;
Console.WriteLine($"The Modulo output is {mod}");
*/


/* Exercise 6 (Write a code that calculates radius of a circle to area)
Console.WriteLine("Give me a radius for a circle");
Console.WriteLine("Type in the radius: ");
string userInputX = Console.ReadLine();
int x = Convert.ToInt32(userInputX);
double answer = 3.142 * x * x;
Console.WriteLine($"The area of the circle is {answer}");
*/

/* Exercise 7 
Console.WriteLine("Give me a number for me to change it's negation");
string userInput = Console.ReadLine();
int x = int.Parse(userInput);
int negationNumber = -x;
Console.WriteLine($"Here's the negation: {negationNumber}");
*/

/* Exercise 8 (Develop a program that takes two integers as input and calculates their product using the multiplication operator.)
Console.WriteLine("Let me multiply two numbers for you");
Console.WriteLine("enter your numbers below");
string userInputX = Console.ReadLine();
Console.WriteLine("x");
string userInputY = Console.ReadLine();
int x = Convert.ToInt32 (userInputX);
int y = Convert.ToInt32 (userInputY);
float answer = x * y;
Console.WriteLine($"The answer is: {answer}");
*/




/*
Console.WriteLine("Give me a number of seconds");
string userInput = Console.ReadLine();
int S = Convert.ToInt32(userInput);
int M = Convert.ToInt32(userInput);
int H = Convert.ToInt32(userInput);
int D = Convert.ToInt32(userInput);

int D = userInput / 86400;
int remainingSeconds = userInput % 86400;

int H = remainingSeconds / 3600;
remainingSeconds %= 3600;

int M = remainingSeconds / 60;

int S = remainingSeconds % 60;

double totalDays = (double)userInput / 86400;
Console.WriteLine($"seconds: {S}");
Console.WriteLine($"minutes: {M}");
Console.WriteLine($"hours: {H}");
Console.WriteLine($"days: {D}");
Console.WriteLine($"In total, that's {totalDays}");
Console.WriteLine($"");
*/
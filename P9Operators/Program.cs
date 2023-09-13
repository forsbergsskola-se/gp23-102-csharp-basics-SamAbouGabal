/* P9Operators main exercise
Console.Write("Enter the number of seconds: ");
int totalSeconds = Convert.ToInt32(Console.ReadLine());


double totalDaysFraction = (double)totalSeconds / 86400;
int days = totalSeconds / 86400;
totalSeconds %= 86400;
int hours = totalSeconds / 3600;
totalSeconds %= 3600;
int minutes = totalSeconds / 60;
int seconds = totalSeconds % 60;

 
Console.WriteLine($"Days: {days}");
Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");

        
Console.WriteLine($"Formatted Time: {days}.{hours}:{minutes}:{seconds}");

Console.WriteLine($"Total Days as a Fraction: {totalDaysFraction}");
*/


/* Km/h to m/s exercise
 
Console.WriteLine("Hello, Give me a Km/h, and i will output m/s");
string userInput = Console.ReadLine();
float number = float.Parse(userInput);
double x = number *1000 / 60 / 60;
Console.WriteLine($"m/s is:{x}");
*/

/* Min to seconds exercise
 
Console.WriteLine("Give me a number of minutes and i will calculate it to seconds");
int userInput = Convert.ToInt32(Console.ReadLine());
int number = userInput * 60;
Console.WriteLine($"{userInput} is {number} seconds");
*/


/* Takes two integers as input and displays their division result as a float exercise
 
Console.WriteLine("Give me the first number to divide:");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("through: ");
int numberY = Convert.ToInt32(Console.ReadLine());
float answer = (float)numberX / numberY;               //only one needs to be (float) doesn't matter wich one
Console.WriteLine($"Your answer is: {answer}");
*/

/* Calculates the remainder of dividing two integers and displays the result exercise
 
Console.WriteLine("Give me a number");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give me another number");
int numberY = Convert.ToInt32(Console.ReadLine());
int mod = numberX % numberY;
Console.WriteLine($"the remainder of the two numbers are: {mod}");
*/


/* calculates radius of a circle to area exercise
 
Console.WriteLine("Give me the radius of a circle");
float userInput = float.Parse(Console.ReadLine());
double answer = userInput * userInput * 3.14159;
Console.WriteLine($"The area of the circle is {answer}");
*/


/* Negation exercise
 
Console.WriteLine("Give me a number for me to change it's negation");
int userInput = int.Parse(Console.ReadLine());
int negationNumber = -userInput;
Console.WriteLine($"Here's the negation: {negationNumber}");
*/


/* Bmi 
Console.WriteLine("input your weight in kg");
float userInputkg = float.Parse(Console.ReadLine());
Console.WriteLine("Input your height in cm");
float userInputcm = float.Parse(Console.ReadLine());
float bodyMass = userInputkg / (userInputcm*userInputcm /100f /100f);
Console.WriteLine($"Your BMI is {bodyMass}");
*/

/* program that takes two integers as input and calculates their product using the multiplication operator exercise
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
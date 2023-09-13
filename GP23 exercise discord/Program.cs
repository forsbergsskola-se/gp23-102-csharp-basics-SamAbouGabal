/*
Console.WriteLine("Hello, Give me a Km/h, and i will output m/s");
string userInput = Console.ReadLine();
float number = float.Parse(userInput);
double x = number *1000 / 60 / 60;
Console.WriteLine($"m/s is:{x}");
*/

/* Exercise 2
Console.WriteLine("Give me a number of minutes and i will calculate it to seconds");
int userInput = Convert.ToInt32(Console.ReadLine());
int number = userInput * 60;
Console.WriteLine($"{userInput} is {number} seconds");
*/

/* Exercise 3
Console.WriteLine("Give me the first number to divide:");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("through: ");
int numberY = Convert.ToInt32(Console.ReadLine());
float answer = (float)numberX / numberY;               //only one needs to be (float) doesn't matter wich one
Console.WriteLine($"Your answer is: {answer}");
*/

/* Exercise 4
Console.WriteLine("Give me a number");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Give me another number");
int numberY = Convert.ToInt32(Console.ReadLine());
int mod = numberX % numberY;
Console.WriteLine($"the remainder of the two numbers are: {mod}");
*/

/* Exercise 5
Console.WriteLine("Give me the radius of a circle");
float userInput = float.Parse(Console.ReadLine());
double answer = userInput * userInput * 3.14159;
Console.WriteLine($"The area of the circle is {answer}");
*/

/*
Console.WriteLine("Give me a number for me to change it's negation");
int userInput = int.Parse(Console.ReadLine());
int negationNumber = -userInput;
Console.WriteLine($"Here's the negation: {negationNumber}");
*/

/*
Console.WriteLine("input your weight in kg");
float userInputkg = float.Parse(Console.ReadLine());
Console.WriteLine("Input your height in cm");
float userInputcm = float.Parse(Console.ReadLine());
float bodyMass = userInputkg / (userInputcm*userInputcm /100f /100f);
Console.WriteLine($"Your BMI is {bodyMass}");
*/

/* Print "$" from userInput
Console.WriteLine("How many dollar do you want mate");
int count = int.Parse(Console.ReadLine());
int print = count;
Console.Write("Here's your cash bruv ");
PRINTAGAIN:
if (print >0)
{
    Console.Write("$");
    print--;
    goto PRINTAGAIN;
}
*/
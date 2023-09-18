/* First exercise. Uses all what we've learned previously
// printing output
Console.WriteLine("What's your age?");
// console input && variable && type
string ageInput = Console.ReadLine();
// conversion && variable && type
int age = int.Parse(ageInput);
// conditional branching && boolean expressions && comparison operator
if (age < 13)
{
    Console.WriteLine("You are a child.");
}

else if (age >= 13 && age <= 19) // can be just (< 19) to simplify ("removes expressions)
{
    Console.WriteLine("You are a teen.");
}

else if (age > 19) // can be just "else" and remove "if age (age > 19)" to simplify
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Give me another integer");
string maximumNumber = Console.ReadLine();
int number = int.Parse(maximumNumber);

// number or age (whatever is greater)
int max; //read like number > age? else number : age
if (number > age)
{
    max = number;
}
else
{
    max = age;
}

{
    Console.WriteLine($"The maximum is {max}");
    if (max % 2== 0)
    {
        Console.WriteLine("It's an even number");
    }
    else
    {
        Console.WriteLine("It's an odd number");
    }
}
*/

/* Exercise 2
Console.WriteLine("Giveth me a numerical and i will presenteth thy with a character");
string userInput = Console.ReadLine();
int characters = int.Parse(userInput);
if (characters >= 90)
{
    Console.WriteLine("A");
}
else if (characters >= 80)
{
    Console.WriteLine("B");
}
else if (characters >= 70)
{
    Console.WriteLine("C");
}
else if (characters >= 60)
{
    Console.WriteLine("D");
}
else if (characters < 60)
{
    Console.WriteLine("F");
}
*/


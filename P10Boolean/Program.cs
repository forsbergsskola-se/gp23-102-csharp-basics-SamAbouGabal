/* Exercie 1 Bool
Console.WriteLine("Type in your age");
string userInput = Console.ReadLine();
int age = Convert.ToInt32(userInput);
bool isChild = age <= 12;
Console.WriteLine($"You are a child:{isChild}");
bool isTeenager = age >= 13 && age <= 19;
Console.WriteLine($"You are a teenager:{isTeenager}");
bool isGrownup = age >= 20;
Console.WriteLine($"You are a grown-up:{isGrownup}");
*/

/* Example for IF / IF ELSE / ELSE
Console.WriteLine("What time is it");
int time = int.Parse(Console.ReadLine());

if (time < 12)
{
    Console.WriteLine("Good morning");
}
else if (time < 18)
{
    Console.WriteLine("Good day");
}
else
{
    Console.WriteLine("Good evening");
}
*/

Console.WriteLine("What's your age?");
int age = Convert.ToInt32(Console.ReadLine());
if(age >= 18)
{
    Console.WriteLine("You are grown up!");
} 
Console.WriteLine("Give me another integer");
int newInt = int.Parse(Console.ReadLine());
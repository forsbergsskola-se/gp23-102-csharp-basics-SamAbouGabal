Console.WriteLine("Oi give me a seed bruv");
string userInput = Console.ReadLine();
int userSeed = int.Parse(userInput);
Random seed = new Random(userSeed);

Console.WriteLine(seed.Next(0, 5));
Console.WriteLine(seed.Next(0, 5));
Console.WriteLine(seed.Next(0, 5));

Console.WriteLine("Three numbers between 0.0 and 0.5:");
Console.WriteLine(seed.NextDouble() * 0.5);
Console.WriteLine(seed.NextDouble() * 0.5);
Console.WriteLine(seed.NextDouble() * 0.5);

Console.WriteLine("Output:Three numbers between 0.2 and 0.7:");
Console.WriteLine(seed.NextDouble() * 0.5 + 0.2);
Console.WriteLine(seed.NextDouble() * 0.5 + 0.2);
Console.WriteLine(seed.NextDouble() * 0.5 + 0.2);

Console.WriteLine("Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
string userInputCrit = Console.ReadLine();
float userCrit = float.Parse(userInputCrit);

if (Random.Shared.NextDouble() < (userCrit))
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No crit");
}
if (Random.Shared.NextDouble() < (userCrit))
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No crit");
}
if (Random.Shared.NextDouble() < (userCrit))
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No crit");
}
if (Random.Shared.NextDouble() < (userCrit))
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No crit");
}
if (Random.Shared.NextDouble() < (userCrit))
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No crit");
}
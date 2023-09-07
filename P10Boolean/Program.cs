Console.WriteLine("Type in your age");
string userInput = Console.ReadLine();
int age = Convert.ToInt32(userInput);
bool isChild = age <= 12;
Console.WriteLine($"You are a child:{isChild}");
bool isTeenager = age >= 13 && age <= 19;
Console.WriteLine($"You are a teenager:{isTeenager}");
bool isGrownup = age >= 20;
Console.WriteLine($"You are a grown-up:{isGrownup}");
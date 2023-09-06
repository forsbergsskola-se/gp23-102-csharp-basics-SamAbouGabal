Console.WriteLine("Give me a number. Preferably 5.6");
string number = Console.ReadLine();
double d = double.Parse(number);
Console.WriteLine(d);
int i  = (int)d;
Console.WriteLine(i);
int o = int.Parse(number);
Console.WriteLine(o);

//First: try assigning it. Error? then
//second: try casting it Error? then
//Third: try parsing it. Error? then
//Last: try converting it. Error? then
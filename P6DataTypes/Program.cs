using System.Globalization;

Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
//Used code above to get "." instead of ","

string outputString = "Hello, World";
Console.WriteLine(outputString);
float decimalValue = 0.3f;
Console.WriteLine(decimalValue);
bool isAwesome = true;
Console.WriteLine(isAwesome);
byte hexByte = 0xa7;
Console.WriteLine(hexByte);
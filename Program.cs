string name = "Bob";
char symbol = 'X';
int experience = 15000;
double gold = 300;
double backpackWeight = 30; 
bool map = true; 

Console.WriteLine("Hero Equipment");
Console.WriteLine($"Name (string): {name}");
Console.WriteLine($"Symbol na mapie (char): {symbol}");
Console.WriteLine($"Experience (int): {experience}");
Console.WriteLine($"Gold (double): {gold}");
Console.WriteLine($"Backpack weight(double): {backpackWeight}");
Console.WriteLine($"Map accquired?(bool): {map}");

experience = 15100;
gold = 310;
backpackWeight = 30.2;

Console.WriteLine("");
Console.WriteLine("Updated report after a fight: ");
Console.WriteLine("Hero Equipment");
Console.WriteLine($"Name (string): {name}");
Console.WriteLine($"Symbol na mapie (char): {symbol}");
Console.WriteLine($"Experience (int): {experience}");
Console.WriteLine($"Gold (double): {gold}");
Console.WriteLine($"Backpack weight(double): {backpackWeight}");
Console.WriteLine($"Map accquired?(bool): {map}");
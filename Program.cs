string name = "Bob";
char symbol = 'X';
int experience = 150;
double gold = 30;
double backpackWeight = 20; 
bool map = true; 

Console.WriteLine("##### TASK 1 #####");
Console.WriteLine("Hero Equipment");
Console.WriteLine($"Name (string): {name}");
Console.WriteLine($"Symbol na mapie (char): {symbol}");
Console.WriteLine($"Experience (int): {experience}");
Console.WriteLine($"Gold (double): {gold}");
Console.WriteLine($"Backpack weight(double): {backpackWeight}");
Console.WriteLine($"Map accquired?(bool): {map}");

experience = 151;
gold = 31;
backpackWeight = 20.2;

Console.WriteLine("");
Console.WriteLine("Updated report after a fight: ");
Console.WriteLine("Hero Equipment");
Console.WriteLine($"Name (string): {name}");
Console.WriteLine($"Symbol na mapie (char): {symbol}");
Console.WriteLine($"Experience (int): {experience}");
Console.WriteLine($"Gold (double): {gold}");
Console.WriteLine($"Backpack weight(double): {backpackWeight}");
Console.WriteLine($"Map accquired?(bool): {map}");

Console.WriteLine("##### TASK 2 #####");

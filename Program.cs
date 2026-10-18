string name = "Bob";
char symbol = 'X';
int experience = 150;
int gold = 30;
double backpackWeight = 20; 
bool map = true;
int arenaFights = 2; 




Console.WriteLine("##### TASK 2 #####");
Console.WriteLine("Hero's Equipment");
Console.WriteLine($"Name (string): {name}");
Console.WriteLine($"Symbol na mapie (char): {symbol}");
Console.WriteLine($"Experience (int): {experience}");
Console.WriteLine($"Gold (int): {gold}");
Console.WriteLine($"Backpack weight(double): {backpackWeight}");
Console.WriteLine($"Arena fights so far (int): {arenaFights}");
Console.WriteLine($"Map accquired?(bool): {map}");

experience += 25;
experience *=2;
gold -=8;
gold +=15;
arenaFights ++;

Console.WriteLine("##### AFTER ARENA FIGHT #####");
Console.WriteLine("Hero's Equipment");
Console.WriteLine($"Name (string): {name}");
Console.WriteLine($"Symbol na mapie (char): {symbol}");
Console.WriteLine($"Experience (int): {experience}");
Console.WriteLine($"Gold (int): {gold}");
Console.WriteLine($"Backpack weight(double): {backpackWeight}");
Console.WriteLine($"Arena fights so far (int): {arenaFights}");
Console.WriteLine($"Map accquired?(bool): {map}");
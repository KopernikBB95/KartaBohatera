Console.WriteLine("##### TASK 4 #####");
Console.WriteLine("");
Console.WriteLine("How many HP (0-100) does your hero have?");
int healthPoints = int.Parse(Console.ReadLine()!);

Console.WriteLine("");
Console.WriteLine("How many potions does he have? ");
int potions = int.Parse(Console.ReadLine()!);

Console.WriteLine("");
Console.WriteLine("Does your hero have a key? (Please type True or False) ");
bool key = bool.Parse(Console.ReadLine()!);

Console.WriteLine("");
Console.WriteLine("Does your hero have a map? (Please type True or False) ");
bool map = bool.Parse(Console.ReadLine()!);

bool alive = healthPoints > 0;
bool hasFullHealthPoints = healthPoints == 100;
bool havePotions = potions > 0;
bool haveNavItem = map || key;
bool readyForAdventure = alive && havePotions && haveNavItem;
bool needsHealing = !hasFullHealthPoints;

Console.WriteLine($"Zyje: {alive}");
Console.WriteLine($"Pelne żyćko: {hasFullHealthPoints}");
Console.WriteLine($"Ma zaopatrzenie: {havePotions}");
Console.WriteLine($"Ma klucz lub mape: {haveNavItem}");
Console.WriteLine($"Gotowy na wyprawe: {readyForAdventure}");
Console.WriteLine($"Potrzebuje leczenia: {needsHealing}");
Console.WriteLine("##### TASK 4 WEEK 3 #####");
Console.WriteLine("");

Console.WriteLine("Podaj ilość punktów życia jaką ma bohater: ");
int healthPoints = int.Parse(Console.ReadLine()!);

Console.WriteLine("Czy bohater posiada klucz? (wpisz \"True\" lub \"False\")");
bool key = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Czy bohater zna haslo? (wpisz \"True\") lub \"False\" ");
bool password = bool.Parse(Console.ReadLine()!);

if (healthPoints <= 0)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Nie możesz wejść, nie żyjesz");
    Console.ResetColor();
}
else if (healthPoints > 0 && (key || password == true) )
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Możesz wejść.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nie możesz wejść. Potrzebujesz klucza bądź hasła.");
    Console.ResetColor();
}
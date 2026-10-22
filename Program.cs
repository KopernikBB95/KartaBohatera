Console.WriteLine("##### TASK 1 WEEK 3 #####");
Console.WriteLine("");
Console.WriteLine("Podaj liczbę: ");
int liczba = int.Parse(Console.ReadLine()!);

if (liczba % 2 == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Liczba jest parzysta");
    Console.ResetColor();
}
else
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine("Liczba jest nieparzysta");
    Console.ResetColor();
}
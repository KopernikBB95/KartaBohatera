Console.WriteLine("##### TASK 3 WEEK 3 #####");
Console.WriteLine("");
Console.WriteLine("Podaj swój wiek: ");
int wiek = int.Parse(Console.ReadLine()!);

if (wiek >= 0)
{
    if (wiek <= 12)
    {
        Console.WriteLine("Dziecko xD");
    }
    else if (wiek <= 17)
    {
        Console.WriteLine("Nastolatek");
    }
    else if (wiek <= 64)
    {
        Console.WriteLine("Osoba dorosła");
    }
    else if (wiek >= 65)
    {
        Console.WriteLine("Senior");
    }
}
else
{
    Console.WriteLine("Wiek nie może być ujemny!");
}
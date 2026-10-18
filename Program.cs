Console.WriteLine("##### TASK 3 #####");
Console.WriteLine("");
Console.WriteLine("Welcome to adventure resources planner.");
Console.WriteLine("How many food rations do you have?");
int foodRations = int.Parse(Console.ReadLine()!);

Console.WriteLine("How many heroes does your team has?");
int heroes = int.Parse(Console.ReadLine()!);

Console.WriteLine("How many days is your adventure going to take?");
int days = int.Parse(Console.ReadLine()!);

Console.WriteLine("");
Console.WriteLine($"Each hero will get: {foodRations/heroes} food rations.");
Console.WriteLine($"After equal split there should be {foodRations%heroes} food rations left.");
double foodRationsPerDay = (double)foodRations/days;
Console.WriteLine($"There will be {foodRationsPerDay:F2} food rations available per day to be split between each team member.");
double foodRationsPerHero = (double)foodRations/heroes;
Console.WriteLine($"There will be {foodRationsPerHero:F2} food rations available for each team member.");
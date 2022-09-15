//Петросян Араик/22-ИСП-2/1 Высокий уровень
try
{
Console.WriteLine("Ввести сторону a:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ввести сторону b:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Ввести сторону c:");
double c = double.Parse(Console.ReadLine());
double medA = 0.5 * Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(c, 2) - Math.Pow(a, 2));
double medB = 0.5 * Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(c, 2) - Math.Pow(b, 2));
double medC = 0.5 * Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(a, 2) - Math.Pow(c, 2));
Console.WriteLine($"Медивна проведенная к стороне a={medA:F2}") ;
Console.WriteLine($"Медивна проведенная к стороне b={medB:F2}");
Console.WriteLine($"Медивна проведенная к стороне c={medC:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
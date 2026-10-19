Console.WriteLine("|        x       |       y      |");
Console.WriteLine("---------------------------------");
for (double x = Math.PI; x <= 2 * Math.PI; x += 0.2)
{
    double y;
    if (x > 3.61) y = Math.Exp(-(x + 0.8));
    else if (x >= 0 && x <= 3.61) y = 1;
    else y = 0.5 * x;
    Console.WriteLine($"|      {x:f1}      |      {y:f2}   |");
}
Console.WriteLine("--------------------------------");

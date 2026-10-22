double[] mas = { Math.PI, 2 * Math.PI };
foreach (double x in mas)
{
    double y;
    if (x > 3.61)
    {
        y = Math.Exp(-(x + 0.8));
    }
    else if (x >= 0 && x <= 3.61)
    {
        y = 1.0;
    }
    else
    {
        y = 0.5 * x;
    }
    Console.WriteLine($"y = {y:F6}");
}

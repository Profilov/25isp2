try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i <= n; i++)
    {
        s += Math.Sin((2 * i - 1) * Math.Pow(x, 2 * i - 1));
    }
    Console.WriteLine($"s={s:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
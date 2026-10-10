try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    int x = int.Parse(Console.ReadLine());
    double Q = 1;
    for (int K = 1; K <= n; K++)
    {
        if (j == 3 || j == 4) continue;
        double s = 0;
        for (int i = j; i <= k + 1; i++)
        {
            if (i == 1) continue;
            s += Math.Pow(i + 5, 1 / 3.0) / (i - 1);
        }
        A *= ((j - 4) * j / (j - 3)) * s;
    }
    Console.WriteLine($"s={A:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.WriteLine("Введите n:");
Console.WriteLine("Введите x:");
int n = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
double Q = 0;
for (int k = 1; k <= n; k++)
{
    int K = 1;
    for (int i = 1; i <= k; i++)
    {
        K *= i;
    }
    Q += (Math.Pow(-1, k) * Math.Pow(x + 3, 2)) / K;
}
Console.WriteLine($"Q={Q:F2}");

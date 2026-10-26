Console.WriteLine("Введите x:");
double x = double.Parse(Console.ReadLine());
double n = 0.00001;
double Q = x;
double term = -(x * x) / 2.0;
int k = 1;
while (Math.Abs(term) >= n)
{
    Q += term;
    k++;
    int m = 2 * k;
    term = -term * (x * x) / ((m - 1) * m);
}
Console.WriteLine($"Результат Q = {Q:F2}");

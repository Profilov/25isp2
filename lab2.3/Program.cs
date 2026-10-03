using System.Text.RegularExpressions;

try
{
    Console.Write("Введите номер варианта:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double a = 0, b = 0, c = 0, y = 0;
    switch (n)
    {
        case 1:
            {
                a = 3.5; b = -0.73; c = 2.5;
            }
            break;
        case 2:
            {
                a = 15.4; b = -5.6; c = 3.5;
            }
            break;
        case 3:
            {
                a = 4.4; b = 5.6; c = 2.7;
            }
            break;
        default: break;
    }
    if (Math.Abs(1-x*x)==a+c)
    {
        y =Math.Sqrt(Math.Abs(a*x-Math.Pow(Math.Cos(b*b*b*x),2)+5.1*c*c));
    }
    else if (Math.Abs(1 - x * x) >a+c)
    {
        y = Math.Exp(0.04 * x)+Math.Log(Math.Abs(b*b*b*b*b*Math.Cos(x)));
    }
    else if (Math.Abs(1 - x * x) < a + c)
    {
        y = Math.Pow(Math.Cos(b * b * b * x*x), 2)+ Math.Log(Math.Abs(b * x - a * a));
    }
    Console.WriteLine($"y = {y:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
// See https://aka.ms/new-console-template for more information
//Базовый
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите r:");
//double r = double.Parse(Console.ReadLine());
//double W = Math.Exp(y + r) + 7.2 * Math.Sin(r);
////Console.WriteLine($"W={W:f2}");
////средний
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите p:");
//double p = double.Parse(Console.ReadLine());
//double N = (3 * y * y + Math.Sqrt(y + 1)) / (Math.Log(p + y) + Math.Exp(p));
//Console.WriteLine($"W=(N:f2");
////Высокий
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double K = (Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log
//    (x))) / (Math.Exp(0) + Math.Asin(6 * x * x));
//Console.WriteLine($"K={K:F2}");



using System.Text.RegularExpressions;
//средний
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите w:");
double w = double.Parse(Console.ReadLine());
double V = (Math.Pow(y + 2*w, 3))/(Math.Log(y + 0.75));
Console.WriteLine($"V={V:f2}");




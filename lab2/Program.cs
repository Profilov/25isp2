//bool A = true;
//bool B = false;
//bool C = false;
//Console.WriteLine(!A||A&&(B||C));
//try
//{
//    Console.WriteLine("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.WriteLine("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    Console.WriteLine(x * x + y * y <= 4);
//    Console.WriteLine((x>=0)||(y*y!=4));
//    Console.WriteLine((x >= 0) && (y * y != 4));
//    Console.WriteLine((x*y!=0)&&(y>x));
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//try
//{
//    Console.WriteLine("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    double y;
//    if (x > 0) y = Math.Sin(x) * Math.Sin(x);
//    else y = 1 - 2 / Math.Sin(x * x);
//    Console.WriteLine($"y={y:f2}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//using System.ComponentModel.Design;

//Console.WriteLine("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.WriteLine("Введите c:");
//double c = double.Parse(Console.ReadLine());
//double d = b * b - 4 * a * c;
//if (d > 0) ;
//{
//    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"x1={x1:f2} x1={x1:f2}");
//}

//Высокий уровень
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine(((x <= 2) && (y <= 2)) || ((x > -2) && (x <= -1) && (y <= -1)));
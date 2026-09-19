//Console.WriteLine($"{Math.PI:f2");
//Console.WriteLine($"{Math.E:f2}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"{a}-вот какое число вы ввели");
//Console.WriteLine("1 13 49");
//Console.WriteLine("7\t15\t100");
//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double d = (-b + Math.Sqrt(b * b - 4 * a * c));
//    Console.WriteLine($"{d:f2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите радиус:");
//    double R = double.Parse(Console.ReadLine());
//    double D = 2 * R;
//    Console.WriteLine($"Диаметр окружности: {D:F2}");
// }
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
//    Console.WriteLine($"Диаметр окружности:{z:f2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите количество сантиметров:");
//    int sm = int.Parse(Console.ReadLine());
//    int m = sm / 100;
//    Console.WriteLine($"Полных метров {m}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите количество килограммов:");
//    int kg = int.Parse(Console.ReadLine());
//    int cn = kg / 100;
//    Console.WriteLine($"Полных центнеров {cn}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите количество килограммов:");
//    int kg = int.Parse(Console.ReadLine());
//    int t = kg / 1000;
//    Console.WriteLine($"Полных тон {t}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите количество метров:");
//    int m = int.Parse(Console.ReadLine());
//    int km = m / 1000;
//    Console.WriteLine($"Полных километров {km}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите количество дней:");
//    int d = int.Parse(Console.ReadLine());
//    int n = d / 7;
//    Console.WriteLine($"Полных недель: {n}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    Console.Write("Введите количество секунд:");
//    int n = int.Parse(Console.ReadLine());
//    int hour = n / 3600;
//    int minute = n % 3600 / 60;
//    int second = n % 3600 % 60;
//    Console.WriteLine($"{hour}:{minute}:{second}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите четырёхзначное число:");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    int s = a + b + c + d;
//    Console.WriteLine(s);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//№14
try
{
    int a = 9;
    int b = 4;
    int c = 6;
    Console.Write("Введите число квартиры:");
    int N = int.Parse(Console.ReadLine());
    int flat =N / (a * c) + 1;
    int entrance = (N  / c + 1) % 9;
    int floor = entrance / 6 ;
    Console.WriteLine($"{flat}:{entrance}:{floor}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
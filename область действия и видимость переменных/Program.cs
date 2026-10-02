//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    if(x<4) Console.WriteLine("Первая область");
//    else Console.WriteLine("Вторая область");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if(x>y)
//    {
//        max = x;
//        min = y;
//    }
//    else
//    {
//        max = y;
//        min = x;
//    }
//    Console.WriteLine($"max={max}, min={min}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    if((a<b)&&(b<c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("Не выполняется");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//using System.ComponentModel.Design;

//try
//{
//    Console.Write("Введите m:");
//   int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m / 10 % 10;
//    int c = m % 10;
//    if((a==4||b==4||c==4)| (a == 7 || b == 7 || c == 7) )
//    Console.WriteLine("Дa");
//    else Console.WriteLine("нет");
//    if ((a == 3 || b == 3 || c == 3) || (a == 6 || b == 6 || c == 6) || (a == 9 || b == 9 || c == 9)) ;
//    else Console.WriteLine("Нет");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    if(n%2==0||n%10==7) Console.WriteLine("Да");
// else Console.WriteLine("Нет");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите a:");
//    int a = int.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    int b = int.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    int c = int.Parse(Console.ReadLine());
//    int max = a;
//    if ((b > a) && (a > c)) max = b;
//    else if ((c > a) && (c > b)) max = c;
//    Console.WriteLine($"max={max}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите x:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    int y = int.Parse(Console.ReadLine());
//    if ((y <= x) && (y <= -x) && (y >= 1));
//    {
//        Console.WriteLine("Точка принадлежит области");
//    }
//    else
//    {
//        Console.WriteLine("Точка не принадлежит области");
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

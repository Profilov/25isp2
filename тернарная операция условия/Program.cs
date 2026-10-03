//try
//{
//    Console.Write("Введите номер дня недели:");
//    int n = int.Parse(Console.ReadLine());
//  switch (n)
//    {
//        case 1:
//            Console.WriteLine("понедельник");
//            break;
//        case 2:
//            Console.WriteLine("вторник");
//            break;
//        case 3:
//            Console.WriteLine("среда");
//            break;
//        case 4:
//            Console.WriteLine("четверг");
//            break;
//        case 5:
//            Console.WriteLine("пятница");
//            break;
//        case 6:
//            Console.WriteLine("суббота");
//            break;
//        case 7:
//            Console.WriteLine("воскресенье");
//            break;
//        default:
//            Console.WriteLine("Нет такого для недели");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите номер месяца:");
//    int n = int.Parse(Console.ReadLine());
//   switch (n)
//    {
//        case 12:case 1:case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3:case 4: case 5:
//            Console.WriteLine("Весна");
//            break;
//        case 6: case 7:  case 8:
//            Console.WriteLine("Лето");
//            break;
//        case 9: case 10:   case 11:
//            Console.WriteLine("Осень");
//            break;
//        default:
//            Console.WriteLine("Нет такого месяца");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите номер карты:");
//    int n = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите масть:");
//    int m = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1:
//            Console.WriteLine("однёрка");
//            break;
//        case 2:
//            Console.WriteLine("двойка");
//            break;
//        case 3:
//            Console.WriteLine("тройка");
//            break;
//        case 4:
//            Console.WriteLine("четвёрка");
//            break;
//        case 5:
//            Console.WriteLine("пятёрка");
//            break;
//        case 6:
//            Console.WriteLine("шестёрка");
//            break;
//        case 7:
//            Console.WriteLine("семерка");
//            break;
//        case 8:
//            Console.WriteLine("восьморка");
//            break;
//        case 9:
//            Console.WriteLine("девятка");
//            break;
//        case 10:
//            Console.WriteLine("деятка");
//            break;
//        case 11:
//            Console.WriteLine("валет");
//            break;
//        case 12:
//            Console.WriteLine("дама");
//            break;
//        case 13:
//            Console.WriteLine("король");
//            break;
//        case 14:
//            Console.WriteLine("туз");
//            break;
//        default:
//            Console.WriteLine("Нет такой карты");
//            break;
//    }
//    switch (m)
//    {
//        case 1:
//            Console.WriteLine("трефь");
//            break;
//        case 2:
//            Console.WriteLine("пики");
//            break;
//        case 3:
//            Console.WriteLine("черви");
//            break;
//        case 4:
//            Console.WriteLine("крести");
//            break;
//        default:
//            Console.WriteLine("Нет такой масти");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите число:");
//    double x = double.Parse(Console.ReadLine());
//    if(x%100>=11&& x%100<=14) Console.WriteLine($"{x}  рублей");
//    else
//    {
//        switch(x%10)
//        {
//            case 1:
//                Console.WriteLine($"{x}  рубль");
//                break;
//            case 2:
//            case 3:
//            case 4:
//                Console.WriteLine($"{x}  рублея");
//                break;
//            default:
//                Console.WriteLine($"{x}  рублей");
//                break;
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//Console.Write("Введите число:");
//int x = int.Parse(Console.ReadLine());
//switch (x)
//{
//    case 1:
//        {
//            double R1=6, R2 = 10, R3 = 2;
//            double RPosl=R1+ R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1*R2*R3)/(R2*R3 + R1*R3 + R1*R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//        }
//        break;
//    case 2:
//        {
//            double R1 = 3, R2 = 5, R3 = 7;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//        }
//        break;
//    case 3:
//        {
//            double R1 = 4, R2 = 12, R3 = 8;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//        }
//        break;
//    default: break;
//}

//Console.Write("Введите номер варианта:");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double a = 0, b = 0, z = 0, y = 0;
//switch (n)
//{
//    case 1:
//        {
//            double R1 = 6, R2 = 10, R3 = 2;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//            a = 1.5; b = 5.7; z = Math.Tan(Math.Abs(Math.Tan(b * x)));
//        }
//        break;
//    case 2:
//        {
//            double R1 = 3, R2 = 5, R3 = 7;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//            a = 3.7; b = 8.4; z = Math.Tan(Math.Abs(Math.Tan(b * x)));
//        }
//        break;
//    case 3:
//        {
//            double R1 = 4, R2 = 12, R3 = 8;
//            double RPosl = R1 + R2 + R3;
//            Console.WriteLine($"Последовательное соединение: {RPosl:F2}");
//            double RPar = (R1 * R2 * R3) / (R2 * R3 + R1 * R3 + R1 * R2);
//            Console.WriteLine($"Параллельное соединение: {RPar:F2}");
//            a = 4.4; b = 5.6; z = Math.Tan(Math.Abs(Math.Tan(b * x)));
//        }
//        break;
//    default: break;
//}
//}
//if (x <= a)
//{
//    y = Math.Pow(a, 3) + Math.Atan(Math.Pow(Math.Sin(b * x), 3)) + Math.Pow(Math.Cos(x * x), 2);
//}
//else if (x > a && x < Math.Log(b))
//{
//    y = Math.Sqrt((a + b * x) + 2) + Math.Sin(z * x);
//}
//else if (x >= Math.Log(b))
//{
//    y = Math.Atan(a + b * x + z);
//}
//Console.WriteLine($"y = {y:F2}");
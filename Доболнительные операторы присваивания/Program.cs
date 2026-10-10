//int s = 0;
//int k = 0;
//int n = 0;
//Console.WriteLine("Введите числа:");
//do
//{
//    try
//    {
//        n = int.Parse(Console.ReadLine());

//        s += n;
//        k++;
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (n != 0);
//k--;
//Console.WriteLine($"Сумма чисел:{s}, количество:{k}");

//int k = 6;
//Console.WriteLine(++k);
//Console.WriteLine(k);
//Console.WriteLine(++k*--k);
//Console.WriteLine(k);
//double s = 0;
//int k = 0;
//Console.WriteLine("Введите числа:");
//do
//{
//    try
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) break;
//        s += n;
//        k++;

//    }
//    catch(Exception e)
//    {
//        Console.WriteLine(e.Message);
//    }
//}
//while (true);
//Console.WriteLine($"Среднее арифмитическое:{s/k:f2}");

//using System.Reflection.Metadata.Ecma335;

//int s = 0;
//int i = 0;
//while (i < 100) 
//{
//    i++;
//    if (i % 5 == 0) continue;
//    s += i;

//}
//Console.WriteLine($"S={s}");

//for (int i = 35; i <= 87; i++)
//{
//    if(i % 7==1 || i%7==2||i%7==5) Console.Write(i+" ");
//}


//try
//{
//    int n = 0;
//    do
//    {


//        Console.WriteLine("Введите n");
//        n = int.Parse(Console.ReadLine());
//        if (n < 0)  Console.WriteLine("Введите положительное число");
//    }
//    while (n < 0); 
//    long F = 1;
//    for (int i = 1; i <= n; i++) F *= i;
//    Console.WriteLine($"Факторил{n}:{F}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Console.WriteLine("Введите число:");
//int n = int.Parse(Console.ReadLine());
//int k3 = 0;
//int klast = 0;
//int k0dd = 0;
//int sumGreater5 = 0;
//long multGreater7 = 1;
//int k05 = 0;
//int last = n % 10;
//while(n!=0)
//{
//    int temp = n % 10;
//    if (temp == 3) k3++;
//    if (temp == last) klast++;
//    if (temp%2 ==0 ) k0dd++;
//    if (temp>5) sumGreater5+=temp;
//    if (temp>7) multGreater7*=temp;
//    if (temp==0||temp==5) k05++;
//    n /= 10;
//}
//Console.WriteLine($"количество 3:{k3}");
//Console.WriteLine($"Последняя цифра встерчаеться:{klast}");
//Console.WriteLine($"Количество чётных:{k0dd}");
//Console.WriteLine($"Сумма больше 5:{sumGreater5}");
//Console.WriteLine($"Произведение его цифр, больше 7:{multGreater7}");
//Console.WriteLine($"Встречаются цифры 0 и 5:{k05}");

//for (int i = 1; i <= 9; i++)//внешний
//{
//    for (int j = 1; j <= 9; j++)//внутренний
//    {
//        Console.Write($" {i}*{j}={i*j} ");
//    }
//    Console.WriteLine();
//}

//int n = 10;
//for (int i=1;i<=5;i++)
//{
//        for (int j = 1;  j<= i; j++)
//    {
//        Console.Write(n+" ");
//    }
//    n += 10;
//    Console.WriteLine();
//}
//3.4
//базовый 30
//double h = 0.2;
//Console.WriteLine("|     x   |     y    |");
//Console.WriteLine("----------------------");
//for (double x=1.1;x<=3.1; x+=0.2)
//{
//    double y = 3 * x - 2 * Math.Log(x) - 5;
//    Console.WriteLine($"| {x:f1} | {y:f2} |");
//}
//Console.WriteLine("----------------------");
//средний 30
//Console.WriteLine("|        x       |       y      |");
//Console.WriteLine("---------------------------------");
//for (double x = -Math.PI / 4; x <= 7 * Math.PI / 4; x += 0.2)
//{

//    double y;
//    if (x > 2.5) y = Math.Cos(2.3 * x + 1);
//    else if (x >= 0 && x <= 2.5) y = 3 * Math.Log(Math.Abs(1 - x * x * x));
//    else y = x * x;
//    Console.WriteLine($"|      {x:f1}      |      {y:f2}   |");
//}
//Console.WriteLine("--------------------------------");

//высокий
//Console.WriteLine("|        x       |       y      |");
//Console.WriteLine("---------------------------------");
//for (double x = -1; x <= 2; x += 0.3)
//{

//    double y;
//    if (x > 0)
//    {
//        y = 0;
//        for (int k = 1; k <= 5; k++)
//        {
//            y += Math.Pow(x, k) / (15 - k * k);
//        }
//    }
//    else
//    {
//        y = Math.Exp(3.5 * x);
//    }
//    Console.WriteLine($"|      {x:f1}      |      {y:f2}   |");
//}
//Console.WriteLine("--------------------------------");
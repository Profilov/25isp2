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
//        k ++;
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
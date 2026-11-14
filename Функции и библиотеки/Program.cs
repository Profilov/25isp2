// вариант 6 базовый
//Console.Write("Введите a:");
//int a = int.Parse(Console.ReadLine()!);
//Console.Write("Введите b:");
//int b = int.Parse(Console.ReadLine()!);
//int Min(int x, int y)
//{
//    if (x < y) 
//        return x;
//    else 
//        return y;
//}
//int z = Min(2 * a, b + a) + Min(2 * a - b, b);
//Console.WriteLine($"Значение z: {z}");

//  высокий
Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Введите C: ");
int C = int.Parse(Console.ReadLine()!);
Console.Write("Введите D: ");
int D = int.Parse(Console.ReadLine()!);

int NOD(int a, int b)
{
    if (a == 0)
        return b;
    else
        return NOD(b % a, a);
}

Console.WriteLine($"НОД(A, B) = {NOD(A, B)}");
Console.WriteLine($"НОД(A, C) = {NOD(A, C)}");
Console.WriteLine($"НОД(A, D) = {NOD(A, D)}");
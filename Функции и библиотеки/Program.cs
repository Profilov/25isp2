// вариант 6 базовый
Console.Write("Введите a:");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите b:");
int b = int.Parse(Console.ReadLine()!);
int Min(int x, int y)
{
    if (x < y) 
        return x;
    else 
        return y;
}
int z = Min(2 * a, b + a) + Min(2 * a - b, b);
Console.WriteLine($"Значение z: {z}");
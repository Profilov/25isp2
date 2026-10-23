//базовый
Random rnd = new Random();
int[,] mas = new int[7, 8];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(1, 10);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
int count = 0;
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        if (mas[i, j] % 2 == 1) count++;
    }
}
Console.WriteLine($"Количество нечётных элементов каждого столбца:{count}");


using Librarylab6;

Random rnd = new Random();
int[,] mas = new int[6, 6];

for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(1, 10);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}

long result = Libraryclasslab6.MultiMatrix(mas);
Console.WriteLine($"\nСумма максимального и минимального элементов главной диагонали матрицы: {result}");
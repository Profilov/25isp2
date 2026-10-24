Random rnd = new Random();
char[] mas = new char[rnd.Next(5, 25)];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = (char)rnd.Next('a', 'f');
}
Console.Write("Массив: ");
for (int i = 0; i < mas.Length; i++)
{
    Console.Write($"{mas[i]} ");
}
Console.WriteLine();
Console.Write("Различные символы в массиве: ");
int count = 0;
for (int i = 0; i < mas.Length; i++)
{
    bool p1 = false;

    for (int j = 0; j < i; j++)
    {
        if (mas[j] == mas[i])
        {
            p1 = true; 
        }
    }
    if (!p1)
    {
        Console.Write($"{mas[i]} ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество различных символов: {count}");
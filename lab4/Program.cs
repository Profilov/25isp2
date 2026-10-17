Random random = new Random();
int[] mas1 = new int[7];
int[] mas2 = new int[9];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i] = random.Next(1, 100);
    Console.Write($"{mas1[i]} ");
}
Console.WriteLine();
for (int j = 0; j < mas2.Length; j++)
{
    mas2[j] = random.Next(1, 100);
    Console.Write($"{mas2[j]} ");
}
Console.WriteLine(); 
int[] mas3 = new int[mas1.Length + mas2.Length];
for (int i = 0; i < mas1.Length; i++)
{
    mas3[i] = mas1[i];
}
for (int j = 0; j < mas2.Length; j++)
{
    mas3[mas1.Length + j] = mas2[j];
}
for (int i = 0; i < mas3.Length - 1; i++)
{
    for (int j = i + 1; j < mas3.Length; j++)
    {
        if (mas3[i] < mas3[j])
        {
            int temp = mas3[i];
            mas3[i] = mas3[j];
            mas3[j] = temp;
        }
    }
}
Console.Write("Третий массив по убыванию значений обоих: ");
for (int i = 0; i < mas3.Length; i++)
{
    Console.Write($"{mas3[i]} ");
}
Console.WriteLine();
    


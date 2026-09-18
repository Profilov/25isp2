try
{
    Console.Write("Введите U:");
    double U = double.Parse(Console.ReadLine());
    Console.Write("Введите R:");
    double R = double.Parse(Console.ReadLine());
    double I = U / R;
    Console.WriteLine($"I={I:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




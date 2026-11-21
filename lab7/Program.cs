using System;

Work[] comps = new Work[5];
for (int i = 0; i < comps.Length; i++)
{
Console.Write("Введите номер трамвая:");
comps[i].trainnumber = Console.ReadLine()!;
Console.Write("Введите время прибытия (Час:Минуты):");
comps[i].arrivaltime = TimeSpan.Parse(Console.ReadLine()!);
Console.Write("Введите время отбытия (Час:Минуты):");
comps[i].departuretime = TimeSpan.Parse(Console.ReadLine()!);
Console.Write("Введите направление:");
comps[i].directions = Console.ReadLine()!;
Console.Write("Введите расстояние:");
comps[i].distances = double.Parse(Console.ReadLine()!);
Console.WriteLine();
}

for (int i = 0; i < comps.Length; i++)
{
comps[i].Print();
}
struct Work
{
    public string trainnumber;
    public TimeSpan arrivaltime;
    public TimeSpan departuretime;
    public string directions;
    public double distances;
    public void Print()
    {
        double speed = distances / (arrivaltime - departuretime).TotalHours;
        Console.WriteLine($"Номер трамвая:{trainnumber}, средняя скорость каждого поезда:{speed:F2}");
    }
}
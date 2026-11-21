Magazin[] comps = new Magazin[5];
for (int i = 0; i < comps.Length; i++)
{
    Console.Write("Введите название продукта:");
    comps[i].namproductname = Console.ReadLine()!;
    Console.Write("Введите фирму производителя:");
    comps[i].manufacturingcompany = Console.ReadLine()!;
    Console.Write("Введите дата производства:");
    comps[i].productiondate = DateOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите срок годности в сутках:");
    comps[i].shelflifeindays = int.Parse(Console.ReadLine()!);
    Console.Write("Введите цену:");
    comps[i].price = decimal.Parse(Console.ReadLine()!);
    Console.WriteLine();
}
Console.Write("Введите номер месяца:");
int month = int.Parse(Console.ReadLine()!);
for (int i = 0; i < comps.Length; i++)
{
    if (comps[i].productiondate.Month == month && comps[i].productiondate.Year == DateTime.Now.Year)
    {
        comps[i].Print();
    }
}

struct Magazin 
{
    public string namproductname;
    public string manufacturingcompany;
    public DateOnly productiondate;
    public int shelflifeindays;
    public decimal price;
    public void Print()
    {
        DateOnly goden = productiondate.AddDays(shelflifeindays);
        Console.WriteLine($"Название:{namproductname}, производитель:{manufacturingcompany}, дата производства:{productiondate}, годен до:{goden}, цена:{price}");
    }
}

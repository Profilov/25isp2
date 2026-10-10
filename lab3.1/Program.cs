Console.WriteLine("Введите a:");
Console.WriteLine("Введите b:");
double a= double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double A = a;
double B = b;
do
{
    try
    {
        if (a > b)
        {
            a =a-b ;
        }
        else 
        {
            b =b-a ;
        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
while (a!=b);

Console.WriteLine($"наибольший общий делитель чисел {A} и {B} равен:{a!}");
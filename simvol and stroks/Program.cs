//char c = 'A';
//Console.WriteLine((int)c);
//for (int i = 35; i < 100; i++) ;
//Console.WriteLine((char)i+"");
//Console.WriteLine();
//Console.WriteLine(char.IsDigit('5'));
//Console.WriteLine(char.IsLetter('X'));

//баз ур 30вар
//char[,] matrix=new char[5,7];
//Random random= new Random();
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            matrix[i, j] = (char)random.Next(40, 70);
//    Console.WriteLine(matrix[i, j]+"");
//    }

//средний ур 30вар
//char[] mas = new char[15];
//for (int i = 0; i < mas.Length; i++)
//    mas[i] = char.Parse(Console.ReadLine()!);
//string word = Console.ReadLine()!;
//int count=0;
//int worldLengtch=word.Length;
//for (int i=0; i<mas.Length-worldLengtch; i++)
//{
//    bool match=true;
//    for (int j = 0; j < worldLengtch; j++)
//    {
//        if (mas[i + j] != word[j])
//        {
//            match = false;
//            break;
//        }
//    }
//}
//int[] a = new int[5];
//Random r = new Random();
//for (int i=0; i<a.Length; i++)
//{
//    a[i] = r.Next(1, 10);
//    Console.WriteLine(a[i]+"");
//}
//Console.WriteLine();
////Array.Clear(a);
//int[] b = new int[5];
//a.CopyTo(b);
//for (int i = 0; i < a.Length; i++)
//{
//    a[i] = r.Next(1, 10);
//    Console.WriteLine(b[i] + "");
//}
//Console.WriteLine();

//30,10,2026

using System.Text.RegularExpressions;
using System.Threading.Channels;

//string s = "456-435-23186";
//string pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}$";

//if(Regex.IsMatch(s,pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("OK");
//else Console.WriteLine("No");


//string s = "daria@mail.ru";
//string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

//if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("OK");
//else Console.WriteLine("No");

//30 variant basic lvl
//string pattern ="^[A-Za-z]$";
//Console.WriteLine("Введите строку:");
//string text = Console.ReadLine()!;
//for (int i=0; i<text.Length; i++)
//{
//    if (Regex.IsMatch(text[i].ToString(),pattern))
//    {
//        text=text.Remove(i, 1);
//        i--;
//    }
//}
//Console.WriteLine(text);
//30 variant average lvl
string pattern = @"\b(sin|cos|log)\b";
Console.WriteLine("Введите строку:");
string text = Console.ReadLine()!;
string result = Regex.Replace(text, pattern, "$1(", RegexOptions.IgnoreCase);
Console.WriteLine(result);

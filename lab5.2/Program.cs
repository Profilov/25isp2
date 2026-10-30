using System.Text.RegularExpressions;
Console.WriteLine("Введите строку:");
string text = Console.ReadLine()!;
string pattern = @"-\+";
string result = Regex.Replace(text, pattern, "0");
Console.WriteLine(result);

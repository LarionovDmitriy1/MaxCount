using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Введите.... Что то введите короче.");
string a=Console.ReadLine();
char[] s = a.ToCharArray();
int count = 0;
int maxcount = 0;
foreach (char c in s)
{
    if (char.IsDigit(c))
    {
        count++;       
        if (maxcount <= count)
        {
            maxcount = count;
        }
    }
    else if(char.IsDigit(c) == false)
    {
        count = 0;
        continue;
    } 
}
Console.WriteLine($"Максимальная последовательность чисел - {maxcount}");
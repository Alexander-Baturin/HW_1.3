/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Вариант решения 1:
int N = new Random().Next(10000, 100000);
string s1 = N.ToString();
if (s1[0] == s1[4] && s1[1] == s1[3])
{
    Console.WriteLine($"Число {N} является палиндромом");
}
else
{
    Console.WriteLine($"Число {N} не является палиндромом");
}


//Вариант решения 2:
/*Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine());
string s1 = N.ToString();
int L = s1.Length;
if (L==5)
{
    if (s1[0] == s1[4] && s1[3] == s1[3])
    {
         Console.WriteLine($"Число {N} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {N} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: число {N} не является пятизначным");
}
*/
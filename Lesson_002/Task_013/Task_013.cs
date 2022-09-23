/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int num = new Random().Next(0, 10000);
string s1 = num.ToString();

var i = 2;
if (s1.Length>2)
{
Console.WriteLine($"Заданное числе {num}, третья цифра заданного числа : {s1[2]}");
}
else
{
Console.WriteLine($"В заданном числе {num} третьей цифры нет");
}
/*int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
    (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
     Console.WriteLine($"Заданное число {n}, третья цифра заданного числа : {k}");
}*/

//Вариант в условиях которого я не смог разобраться


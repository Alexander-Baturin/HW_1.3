/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int num = new Random().Next(0, 10000);
string s1 = num.ToString();
char secondChar = s1 [2];
var i = 0;
if (i < s1.Length)
{
    if (i==2)
    {
        Console.WriteLine($"Заданное числе {num}, третья цифра заданного числа : {secondChar}");
    }   
    else
    {
        i++;
    }
}

    
Console.WriteLine($"В заданном числе {num} третьей цифры нет");



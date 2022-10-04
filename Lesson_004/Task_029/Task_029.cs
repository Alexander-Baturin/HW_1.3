//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]
Console.Clear();
int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Mass (i) + " ");
 }
Console.Write("]");

int Mass (int a)
{
    return numbers[a];
}
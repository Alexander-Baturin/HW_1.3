﻿/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


int N = new Random().Next(1, 8);
Console.Write("N = ");
Console.WriteLine(N);
int S = 6;
int NW = 8;

if (N >= S && N < NW)
{
    Console.WriteLine($"Выбранный день недели {N}, является выходным");
}
else if (N<S)
{
    Console.WriteLine($"Выбранный день недели {N}, не является выходным");
}
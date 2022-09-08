//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine());
int count = N-N;
while (count<=N)
{
    if (count%2==0)
    {
        Console.Write(count+ "; " );
        count = count+2;
    }
    else
    {
        count++;
    }
}

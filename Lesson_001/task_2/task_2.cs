int a = new Random().Next(0, 10);
Console.WriteLine(a);
int b = new Random().Next(0, 10);
Console.WriteLine(b);
int max = 0;
int min = 0;
if(a>b)
{
    Console.Write("max = ");
    Console.WriteLine(max = a);
    Console.Write("min = ");
    Console.WriteLine(min = b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(max = b);
    Console.Write("min = ");
    Console.WriteLine(min = a);
}
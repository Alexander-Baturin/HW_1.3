int a = new Random().Next(0, 10);
Console.WriteLine(a);
int b = new Random().Next(0, 10);
Console.WriteLine(b);
int max = a;
if(a>b)
{
    Console.WriteLine(max = a);
}
else
{
    Console.WriteLine(max = b);
}
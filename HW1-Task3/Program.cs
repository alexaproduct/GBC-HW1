// Выяснить является ли число чётным

int N = new Random().Next(1,100);
Console.WriteLine(N);

int i = N/2;
Console.WriteLine("N/2= " + i);

int x = N-i;
Console.WriteLine("x= " + x);

if(i == x)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
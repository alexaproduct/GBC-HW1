// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int N = new Random().Next(10,99);
Console.WriteLine(N);

int a = N/10;
Console.WriteLine("a=" + a);

int b = N-a*10;
Console.WriteLine("b=" + b);

if(a > b)
{
    Console.WriteLine("a = макс");
}
else
{
    if(b > a)
    {
        Console.WriteLine("b = макс");
    }
    else
    {
         Console.WriteLine("числа равны");
    }
}
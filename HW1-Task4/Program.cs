// Показать четные числа от 1 до N

int N = new Random().Next(1,100);
Console.WriteLine("N= " + N);

int b = 1+1;

while(b<=N)
{
    Console.WriteLine(b);
    b = b + 2;
}




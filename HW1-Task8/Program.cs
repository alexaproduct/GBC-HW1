// Удалить вторую цифру трёхзначного числа

int N = new Random().Next(99,1000);
Console.WriteLine(N);

int a = N/100;
Console.WriteLine(a);

int b = (N-a*100)/10;
Console.WriteLine(b);

int c = N-a*100-b*10;
Console.WriteLine(c);

int N2 = a*10+c;
Console.WriteLine(N2);
// Показать вторую цифру трёхзначного числа

int N = new Random().Next(1,1000);
Console.WriteLine(N);

int a = N/100;

int b = (N-a*100)/10;
Console.WriteLine(b);

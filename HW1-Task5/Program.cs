// Показать последнюю цифру трёхзначного числа

int N = new Random().Next(1,1000);
Console.WriteLine(N);

int a = N/100;

int b = (N-a*100)/10;

int c = N-a*100-b*10;
Console.WriteLine(c);
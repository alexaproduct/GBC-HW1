// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите 3-значное число:");
int i = int.Parse(Console.ReadLine());


if (i/1000 > 1 || i/100 < 1) Console.WriteLine("Не является 3-значным числом. Введите 3-значное число.");
else if (i/100 > 1)
{
    int k = i%10;
    Console.WriteLine(k);
}


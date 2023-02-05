// Показать вторую цифру трёхзначного числа

Console.WriteLine("Первый вариант решения");

Console.WriteLine("Введите 3-значное число:");
int i = int.Parse(Console.ReadLine());


if (i/1000 > 1 || i/100 < 1) Console.WriteLine("Не является 3-значным числом. Введите 3-значное число.");

int k = (i%100-i%10)/10;
Console.WriteLine("2-я цифра = "+k);

// Второй вариант решения - через string

Console.WriteLine("Второй вариант решения - через String");

string stringNumber = Convert.ToString(i);
Console.WriteLine("2-я цифра 3-значного числа -> "+stringNumber[1]);
// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите 3-значное число:");
int i = int.Parse(Console.ReadLine());


if (i/1000 > 1 || i/100 < 1) Console.WriteLine("Не является 3-значным числом. Введите 3-значное число.");

else
{
    int i1 = i/100;
    Console.WriteLine("Первое число = "+i1);
    int i3 = i%10;
    Console.WriteLine("Третье число = "+i3);
    int TwoDigit = i1*10+i3;
    Console.WriteLine("Новое двузначное число = "+TwoDigit);
}
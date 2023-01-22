// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите число A");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine());

int i = numberA/numberB;

if (i == numberB)
{
    Console.WriteLine("да, первое число является квадратом второго");
}
else
{
    Console.WriteLine("нет, первое число не является квадратом второго");
}

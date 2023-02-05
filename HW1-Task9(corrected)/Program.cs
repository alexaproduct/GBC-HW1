// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int A = 100;
Console.WriteLine("Задано число A = "+A);

Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());

int ostatok1 = A%B;

if (A%B == 0) Console.WriteLine("кратно");
else Console.WriteLine(ostatok1);


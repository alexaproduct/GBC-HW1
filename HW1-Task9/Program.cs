// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int X = 12;
Console.WriteLine("X = " + X);

int Y = 5;
Console.WriteLine("Y = " + Y);

int Z = X/Y;

int A = X-Z*Y;
Console.WriteLine("Остаток = " + A);

if (A == 0)
{
   Console.WriteLine("X и Y кратны, частное = " + Z);
}
else
{
    Console.WriteLine("X и Y не кратны, остаток = " + A);
}
// Найти третью цифру числа или сообщить, что её нет

int X = new Random().Next(1,10000);
Console.WriteLine("X = " + X);

int N3 = X/100;

int N4 = X/1000;

if (N3 > 0)
{
    Console.WriteLine("Есть цифра #3 в числе X");
    if (N4 == 0)
    {
         int a = X/100;
         int b = (X-a*100)/10;
         int c = X-a*100-b*10;
         Console.WriteLine("Цифра #3 в числе X = " + c);
    }
    else
    {
            int d = X/1000;
            int e = (X-d*1000)/100;
            int f = (X-d*1000-e*100)/10;
            Console.WriteLine("Цифра #3 в числе X = " + f);
    }
}
else
{
     Console.WriteLine("цифры #3 в числе X нет");
}


// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число:");
int i = int.Parse(Console.ReadLine());

if (i/100 < 1) 
{
    Console.WriteLine("Нет 3-й цифры в числе. Введите число из 3-х или более цифр.");
}
else
{
    string stringNumber = Convert.ToString(i);
    Console.WriteLine("третья цифра этого числа -> "+stringNumber[2]);
}
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99)
{int div1 = num % 10;
Console.Write($"{div1} ");}
else
{
Console.Write("третьего числа нет");
}


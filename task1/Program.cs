﻿//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int div1 = (num/10)%10;
Console.Write($"{div1} ");

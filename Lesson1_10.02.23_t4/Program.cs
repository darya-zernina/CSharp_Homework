﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число 1:  ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:  ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите число 3:  ");
int c = int.Parse(Console.ReadLine());
int max = 0;
if(a > max)
{
    max = a;
}
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine("max = " + max);

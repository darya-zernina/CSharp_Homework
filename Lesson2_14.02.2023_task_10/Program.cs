//Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a1 = num / 10;
int a2 = a1 % 10;
System.Console.WriteLine(a2);


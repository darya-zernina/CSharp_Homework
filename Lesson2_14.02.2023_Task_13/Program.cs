// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num>99 && num<1000)
{
  int a1 = num % 10; 
  System.Console.WriteLine(a1);
}
else System.Console.WriteLine("Нет третьей цифры");


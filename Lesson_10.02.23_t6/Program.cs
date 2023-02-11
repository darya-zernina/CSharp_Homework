// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int i = number % 2;

if(i == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

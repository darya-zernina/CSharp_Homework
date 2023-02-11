// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
int x = Number % 2;
if (x == 0);
{
    Console.WriteLine("да");
}
else  
{
    Console.WriteLine("Нет");
}

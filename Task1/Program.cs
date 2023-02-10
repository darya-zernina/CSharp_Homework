Console.Write("Введите число 1:  ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число 2:  ");
int y = int.Parse(Console.ReadLine());
int sqr = y*y;
if (sqr == x)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадротом второго");
}
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = 1;
Consequense(N, start);

string Consequense(int number, int start)
{    
    if (number == 0) return String.Empty; 
    else     return $"{Consequense(start, number - 1)}{number} "; 
}
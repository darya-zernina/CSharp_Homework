// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите любое количество чисел через пробел: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for(int i = 0; i < numbers.Length; i++)
{
if (numbers[i] > 0)
    {
    sum++;
    }
}
Console.WriteLine("Количество чисел больше 0 составляет: " + sum);






// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array [i, j] = Convert.ToInt32(new Random().Next(0,20));
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int FindMin(int[,] array, int i)
{
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int a = 1; a < array.GetLength(0); a++)
{
  int tempSumLine = SumLineElements(array, a);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = a;
  }
}
return minSumLine;
}

Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
CreateArray(array);
PrintArray(array);
int sumLine = SumLineElements(array, 0);
int minSumLine = FindMin(array, 0);

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов ");

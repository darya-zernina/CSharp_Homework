// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];//создание массива 
        for (int i = 0; i < size; i++) 
        {   
        res[i] = new Random().Next(minValue, maxValue + 1);
        }     return res;
}  

void PrintArray(int[] inArray)
        {
        for (int i = 0; i < inArray.Length; i++)
        {         
            Console.Write($"{inArray[i]} ");  
        } 
} 

int Sum (int[] inArray)
{     
    int result = Convert.ToInt32("ReadLine ");
    result = 0;
    
    for (int i = 0; i < inArray.Length; i++)
    {         
        if(i % 2 == 1); 
        result = inArray[i] + inArray[i]; 
    }
    return result;
} 
 int[] array = GetArray(12, -9, 9);
 PrintArray(array); 
 System.Console.WriteLine();
     Console.WriteLine($"Сумма нечетных чисел = {Sum}"); 

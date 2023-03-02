// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];//создание массива 
        for (int i = 0; i < size; i++) 
        {   
        res[i] = new Random().Next(minValue, maxValue + 1);
        }     
        return res;
}  

void PrintArray(int[] inArray)
        {
        for (int i = 0; i < inArray.Length; i++)
        {         
            Console.Write($"{inArray[i]} ");  
        } 
} 

double FindDiff(double[] arr)
{
   double result = Convert.ToInt32(Console.ReadLine());
   result = 0; 
            Array.Sort(arr);
        if (arr.Length > 0)
         {
            Console.WriteLine("Minimum number is " + arr[0]);
            Console.WriteLine("Maximum number is " + arr[arr.Length - 1]);
       
    result = arr[arr.Length - 1] - arr[0];
   
        }
         return result;
}
double[] array = GetArray(12, -9, 9);
 PrintArray(array); 
 System.Console.WriteLine();
     Console.WriteLine($"Сумма нечетных чисел = {FindDiff}"); 
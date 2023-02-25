// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(int size, int minValue, int maxValue)
 {   
      int[] res = new int[size];//создание массива
           for (int i = 0; i < size; i++)  
              {         res[i] = new Random().Next(minValue, maxValue + 1);
                   } 
                  return res; 
                  }  
void PrintArray(int[] inArray)
 {     
    for (int i = 0; i < inArray.Length; i++)
     {         Console.Write($"{inArray[i]} "); 
         } 
         } 
         
int[] array = GetArray(8, -9, 9);
 PrintArray(array);
 
  
int[] GetArray(int size, int minValue, int maxValue)
 {    
 int[] res = new int[size];  
    for (int i = 0; i < size; i++)  
       {   
              res[i] = new Random().Next(minValue, maxValue);
    }     return res; 
    }  

void PrintArray(int[] massive)
{

}
int[] array = GetArray(10, 0, 10);
 Console.WriteLine(string.Join(" ", array)); 



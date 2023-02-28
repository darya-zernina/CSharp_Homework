
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int FindSum(int[] inArray, int number)
{
 int index = 0;
for (int i = 0; i < inArray.Length; i++)
if (inArray[i] % 2 == 0)
index++; 
return index  
}
 
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
Console.WriteLine($"всего {numbers.Length} чисел");

int sum = FindSum(index);

//Console.WriteLine($"Ответ: {FindSum(number)}");
//int SQR = FindSQR(numberA, numberB);
 // Console.WriteLine("Ответ: " + SQR);
   // Console.WriteLine($"Ответ = {FindSQR(numberA, numberB)}");


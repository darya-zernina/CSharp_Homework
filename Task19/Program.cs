// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число:");        
int number = Convert.ToInt32(Console.ReadLine());        
int reversedNumber = 0;        
int temp = number;        
 while (temp > 0)        
    {        
     reversedNumber = reversedNumber * 10 + temp % 10;    
     temp /= 10;     
    }        
 if (number == reversedNumber)     
     Console.WriteLine("Число палимдромное.");    
 else            
 Console.WriteLine("Число не палимдромное.");

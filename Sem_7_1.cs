// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
        
 static void PrintNumbers(int m, int n)
    {
         if (m > n) return;  
        Console.WriteLine(m);
        PrintNumbers(m + 1, n);
          
        int M = 1;
        int N = 5;
   PrintNumbers(M, N);
    }
     




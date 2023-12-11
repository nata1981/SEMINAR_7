// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void  PrintReverse(int[] array, int index)
        {
              if (index < 0) return;
          Console.WriteLine(array [index]);
           PrintReverse(array, index - 1);
    
            int[] array = { 1,  2,  5,  0, 10, 34 };
           
            PrintReverse(array, array.Length - 1);
        }

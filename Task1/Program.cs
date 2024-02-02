// Задача 1: Задайте значения M и N.
// Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// Пример: M = 1; N = 5 -> "1, 2, 3, 4, 5"
//        M = 4; N = 8 -> "4, 5, 6, 7, 8"


 
    void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m);
            
            if (m < n)
            {
                Console.Write(", ");
            }
            PrintNaturalNumbers(m + 1, n);
        }
        return;
    }

        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Натуральные числа в промежутке от {m} до {n}: ");
        PrintNaturalNumbers(m, n);
        Console.ReadLine();
  

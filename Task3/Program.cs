// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
// Пример: [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1


int[] arr = { 15, 7, 36, 99, 103, 2, 27 };

    void CreateRevArray(int[] arr, int i)
    {
        if (i >= 0)
        {
            Console.Write($"{arr[i]} ");
            CreateRevArray(arr, i - 1);
        }
    }

Console.Write("Reversed Array: ");
CreateRevArray(arr, arr.Length - 1);

Console.ReadLine();



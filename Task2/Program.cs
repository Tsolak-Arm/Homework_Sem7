// Задача 2:
// Напишите программу вычисления
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int SolveAkkermanFunction(int m, int n)
{
    int result = 0;
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return SolveAkkermanFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return SolveAkkermanFunction(m - 1, SolveAkkermanFunction(m, n - 1));
    }
    return result;
}

Console.WriteLine($"Input m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = int.Parse(Console.ReadLine());
int result = SolveAkkermanFunction(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");


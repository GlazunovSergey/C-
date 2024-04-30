// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void TwoToN(int n, int m)
{
    if (m > n)
    {
        TwoToN(m - 1, n);
        System.Console.Write(m + " ");
    }
    else if (n > m)
    {
        TwoToN(m, n - 1);
        System.Console.Write(n + " ");
    }
    else System.Console.Write(m + " ");
}
TwoToN(2,8);

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Acc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Acc(m - 1, 1);
//     }
//     else
//     {
//         return Acc(m - 1, Acc(m, n - 1));
//     }
// }

// System.Console.WriteLine(Acc(2, 3));

// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] arr = { 6, 2, 8, 14, 5 };

// void PrintArr(int[] arr)
// {
//     if (arr.Length > 0)
//     {
//         System.Console.Write(arr[arr.Length - 1] + " ");
//         PrintArr(arr.Take(arr.Length - 1).ToArray());
//     }
// }

// PrintArr(arr);
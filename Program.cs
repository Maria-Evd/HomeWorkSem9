// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"{PrintNumbers(N, 1)}");

// string PrintNumbers(int start, int end)
// {
//     if(start == end) return start.ToString();
//     return start +" "+ PrintNumbers(start - 1, end);
// }


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равно {SumNumbers(m, n)}");

// int SumNumbers(int m, int n)
// {
//     if (m == n) return n;
//     return m + SumNumbers(m + 1, n);
// }


// Задача 68: Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число N: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Функция Аккермана А({m},{n}) = {AkkNumbers(m, n)}");

// int AkkNumbers(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0) return AkkNumbers(m - 1, 1);
//     return AkkNumbers(m - 1, AkkNumbers(m, n-1));
// }
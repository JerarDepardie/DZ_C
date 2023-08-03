// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 1;

// string PrintNumber(int start, int end)
// {
//     if(start==end)
//     {
//         return start.ToString();
//     }
//     return (start+ " "+ PrintNumber(start-1, end));
// }

// Console.WriteLine(PrintNumber(num, count));


//////////////////////////////////////////////////////////////////////


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// int PrintNumber(int start, int end)
// {
//     if(start==end)
//     {
//         return sum += start;
//     }
//     return sum += start + PrintNumber(start+1, end);
// }

// PrintNumber(num, num2);
// System.Console.WriteLine(sum);


//////////////////////////////////////////////////////////////////////


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int result = result = AckermannFunction(num, num2);

// System.Console.WriteLine(result);

// int AckermannFunction(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (m > 0 && n == 0)
//         return AckermannFunction(m - 1, 1);    
//     return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
// }
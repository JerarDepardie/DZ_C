// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double [,] matrix= new double[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = Math.Round(new Random().NextDouble() * 15.0, 3);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }


/////////////////////////////////////////////////////////////////////////////////////////////////


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 
// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[new Random().Next(1,5),new Random().Next(1,5)];

// int num = 0;
// bool flag = false;

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(10);
//         Console.Write(matrix[i,j]+ " ");
//         if (i == columns && j == rows)
//         {
//             num = matrix[i,j];
//             flag = true;
//         }    

//     }
//     Console.WriteLine();
// }

// if (flag == true)
//     System.Console.WriteLine($"Ваще число: {num}");
// else
//     System.Console.WriteLine("Нет такого числа");


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите первое число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] matrix= new int[rows,columns];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j <  matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(10);
//         Console.Write(matrix[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// System.Console.Write("Среднее арефметическое столбцов равно : ");

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     double sa = 0;
//     for (int i = 0; i <  matrix.GetLength(0); i++)
//     {
//         sa += matrix[i,j];
//     }
//     System.Console.Write(sa / rows + "; ");
// }
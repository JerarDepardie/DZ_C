//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Write("Введите число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, colomns];

// void Getatirx()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void GoLowMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//             {
//                 for (int k = 0; k < matrix.GetLength(1) - j - 1; k++)
//                 {
//                     if (matrix[i, k] < matrix[i, k + 1])
//                     {
//                         int temp = matrix[i, k];
//                         matrix[i, k] = matrix[i, k + 1];
//                         matrix[i, k + 1] = temp;
//                     }
//                 }
//             }
//         }
// }

// Getatirx();
// PrintMatrix();
// System.Console.WriteLine("______________________");
// GoLowMatrix();
// PrintMatrix();


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("Введите число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int colomns = Convert.ToInt32(Console.ReadLine());

// int summa = 0;
// int minSum = 9999999;
// int index = 0;

// int[,] matrix = new int[rows, colomns];


// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(11);
//         summa += matrix[i,j];
//     }
//     if (summa < minSum)
//     {
//         minSum = summa;
//         index = i;
//     }
//     summa = 0;
// }

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// PrintMatrix();
// System.Console.WriteLine($"Наименшая сумма числе на строке - {index + 1}");


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Console.Write("Введите число сток первой матрицы: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов первой матрицы: ");
// int colomns1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число строк второй матрицы: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов второй матрицы: ");
// int colomns2 = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows1, colomns1];
// int[,] matrix2 = new int[rows2, colomns2];
// int[,] resultMatrix = new int[rows1, colomns2];

// void Getatirx(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(11);
//         }
//     }
// }

// void PrintMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void UltiplyMatrix(int[,] matrices1, int[,] matrices2)
// {
//     for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < colomns2; j++)
//             {
//                 int sum = 0;
//                 for (int k = 0; k < colomns1; k++)
//                 {
//                     sum += matrices1[i, k] * matrices2[k, j];
//                 }
//                 resultMatrix[i, j] = sum;
//             }
//         }

// }



// Getatirx(matrix);
// PrintMatrix(matrix);
// System.Console.WriteLine("______________");

// Getatirx(matrix2);
// PrintMatrix(matrix2);
// System.Console.WriteLine("______________");

// if (colomns1 != rows2)
//     System.Console.WriteLine("Матрицы не могут перемножится, попробуйте ввести другие значения");
// else
// {
//     UltiplyMatrix(matrix, matrix2);
//     PrintMatrix(resultMatrix);
// }


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Write("Введите число: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int colomns1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число: ");
// int colomns2 = Convert.ToInt32(Console.ReadLine());

// int[,,] matrix = new int[rows1, colomns1, colomns2];

// void Getatirx(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i,j,k] = new Random().Next(10, 100);
//                 System.Console.Write(array[i,j,k] + $"({i}, {j}, {k})" + " ");
//             }
//             System.Console.WriteLine();
//         }
//         System.Console.WriteLine();
//     }
// }

// Getatirx(matrix);


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Напишите программу, которая заполнит спирально массив 4 на 4.

// int rows1 = 4;
// int colomns1 = 4;

// int count = 1;
// int[,] matrix = new int[rows1, colomns1];

// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     matrix[0, i] = count;
//     ++count;
// }

// for (int i = 1; i < matrix.GetLength(0); i++)
// {
//     matrix[i, matrix.GetLength(1) - 1] = count;
//     ++count;
// }

// for (int i = 2; i > -1; i--)
// {
//     matrix[3, i] = count;
//     ++count;
// }

// for (int i = 2; i > 0; i--)
// {
//     matrix[i, 0] = count;
//     ++count;
// }

// for (int i = 1; i < 3; i++)
// {
//     matrix[1, i] = count;
//     ++count;
// }


// matrix[2,2] = count;
// ++count;
// matrix[2,1] = count;

// void PrintMatrix()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// PrintMatrix();

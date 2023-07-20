// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = new int[8];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     if (array[i] % 2 == 0)
//         count++;
//     System.Console.Write(array[i] + " ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine(count);


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int[8];
// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(50);
//     if (i % 2 == 1)
//         sum += array[i];
//     System.Console.Write(array[i] + " ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine(sum);


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[8];
// double max = 0;
// double min = 15;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(new Random().NextDouble() * 15.0, 3);
//     System.Console.Write(array[i] + " ");
//     if (array[i] > max)
//         max = array[i];
//     if (array[i] < min)
//         min = array[i];
// }
// System.Console.WriteLine();

// System.Console.WriteLine($"Максимум равен: {max}, а минимум: {min}");
// System.Console.WriteLine($"Разница равна: {Math.Round(max - min, 3)}");
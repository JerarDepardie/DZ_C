// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 10 == number / 10000) && ((number % 100) / 10 == (number / 1000) % 10))
        Console.WriteLine("Полиндром");

else
    Console.WriteLine("Не полиндром");


///////////////////////////////////////////////////////////////////////////////////////////////////////


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите перву точку:");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите вторую точку:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine(Math.Round(result, 2));


//////////////////////////////////////////////////////////////////////


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите Число:");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= num; i++)
    Console.WriteLine(Math.Pow(i, 3));
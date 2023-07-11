// Программа принимает на вход трехзначное число, а выводит второе

Console.Write("Введите трехзначное висло: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((numberTwo % 100) / 10);


////////////////////////////////////////////////////////////////////

// Получает число, на выход дает третью цифру справа, если ее нет, выводим что ее нет

Console.Write("Введите число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());

if (numberThree / 100 == 0)
    Console.WriteLine("третьей цифры нет");

else
{
    while(numberThree >= 1000)
        numberThree = numberThree / 10;
    
    Console.WriteLine(numberThree % 10);
}

///////////////////////////////////////////////////////////////////


// Дело сделано
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.f

Console.Write("Ведите цифру обозначающую день недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());

if (numberWeek == 7 || numberWeek == 6)
    Console.WriteLine("Да");

else
    Console.WriteLine("Нет");
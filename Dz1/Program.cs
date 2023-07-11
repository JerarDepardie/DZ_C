// Какое число больше а какое меньше
Console.WriteLine("Какое число больше а какое меньше");
Console.Write("Введите первое числ: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе числ: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < number2)
{
    Console.Write(number1);
    Console.Write(" меньше чем ");
    Console.WriteLine(number2);
}
else if (number1 > number2)
{
    Console.Write(number1);
    Console.Write(" больше чем ");
    Console.WriteLine(number2);
}
else
{
    Console.Write(number1);
    Console.Write(" равно ");
    Console.WriteLine(number2);
}

// Следующие три строки нужны для того что бы в консоле все задания не склеивались, и между ними было пару пустых строк
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

//Найти максимальное число среди трех
Console.WriteLine("Найти максимальное число среди трех");

Console.WriteLine("Ввелите три числа");
int number3 = Convert.ToInt32(Console.ReadLine());
int number4 = Convert.ToInt32(Console.ReadLine());
int number5 = Convert.ToInt32(Console.ReadLine());
int max = number3;
if (number4 > max)
{
    max = number4;
}
if (number5 > max)
{
    max = number5;
}
Console.Write("Самое большое число: ");
Console.WriteLine(max);


// Следующие три строки нужны для того что бы в консоле все задания не склеивались, и между ними было пару пустых строк
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");


// Является ли число четным

Console.WriteLine("Является ли число четным");
Console.Write("Введите число: ");
int ChetNechet = Convert.ToInt32(Console.ReadLine());
if (ChetNechet % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

// Следующие три строки нужны для того что бы в консоле все задания не склеивались, и между ними было пару пустых строк
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

// Числа от 1 до N

Console.WriteLine("Числа от 1 до N");
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (N > 0)
{
    while (i <= N)
    {
        Console.Write(i);
        Console.Write(", ");
    i++;
    }
}
else
{
    while (N <= i)
    {
        Console.Write(N);
        Console.Write(", ");
    N++;
    }
}

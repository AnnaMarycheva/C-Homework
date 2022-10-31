// Задача 64: Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
Console.WriteLine("Введите натуральное число больше 1:");
int num = int.Parse(Console.ReadLine());

void Number (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    Number (number - 1);
}

Number(num);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
/*
Console.WriteLine("Введите начальное число M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numN = int.Parse(Console.ReadLine());


void GapNumberSum (int numM, int numN, int sum)
{
    if (numM > numN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numM++);
    GapNumberSum(numM, numN, sum);
}

GapNumberSum(numM, numN, 0);
*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите начальное число M:");
int numM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numN = int.Parse(Console.ReadLine());


int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM != 0 && numN == 0) return AckermannFunction(numM - 1, 1);
    if (numM > 0 && numN > 0) return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));
return AckermannFunction(numM, numN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {AckermannFunction(numM, numN)}");

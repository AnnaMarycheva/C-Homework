﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*int SecondNum (int num)
{
    int dec = (num / 10) % 10;   
    return dec;
}
Console.Write("ВВедите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondNum (num);
Console.Write($"Вторая цифра числа {num} -> {result}.");*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*int ThirdNum (int num)
{
    int dec = (num / 10) % 10;   
    return dec;
}
Console.Write("ВВедите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SecondNum (num);
Console.Write($"Вторая цифра числа {num} -> {result}.");*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void DayOfWeek (int num)
{
    if (num > 5)

    Console.Write("День является выходным");
    else 
    Console.Write("День НЕ является выходным");
}

Console.Write("ВВедите число от 1 до 7 обозначающее день недели ");
int num = Convert.ToInt32(Console.ReadLine());
DayOfWeek(num);
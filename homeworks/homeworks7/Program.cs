// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for(int i=0; i < rows;i++)
        for(int j=0; j<columns;j++)
        {
            newArray[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue +1), 2);
        }
        return newArray;
   
}
void Show2Darray (double[,] array)
{
        for(int i=0; i < array.GetLength(0);i++)
        {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
   
}
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DRandomArray (m,n, min,max);
Show2Darray(myArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*
int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)

{
    int[,] newArray = new int[rows, columns];
    for(int i=0; i < rows;i++)
        for(int j=0; j<columns;j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
        }
        return newArray;
   
}
void Show2Darray (int[,] array)
{
        for(int i=0; i < array.GetLength(0);i++)
        {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
   
}
}

void Element(int[,] array)
{
    
    Console.WriteLine("ВВедите номер строки элемента ");
        int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("ВВедите номер столбца элемента ");
        int j = Convert.ToInt32(Console.ReadLine());
        
    Console.WriteLine($"Элемент массива со строкой {i}  и столбцом {j} -> {array[i,j]} ");
    } 
   

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray (m,n, min,max);
Show2Darray(myArray);
Element(myArray);
*/



//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)

{
    int[,] newArray = new int[rows, columns];
    for(int i=0; i < rows;i++)
        for(int j=0; j<columns;j++)
        {
            newArray[i,j] = new Random().Next(minValue,maxValue +1);
        }
        return newArray;
   
}
void Show2Darray (int[,] array)
{
        for(int i=0; i < array.GetLength(0);i++)
        {
        for(int j=0; j<array.GetLength(1);j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
   
}
}

void AvgColumns (int [,] array)

{
    Console.Write("Среднее арифметическое каждого столбца: ");  
    for(int j=0; j<array.GetLength(1);j++)
    {   double sum = 0;
        for(int i=0; i < array.GetLength(0);i++)
        {
            sum = array[i,j] + sum;
        }
    double avgColumns = Math.Round(sum/array.GetLength(0), 2);
    Console.Write($"{avgColumns + " "}");
    //не получилось организовать вывод результатовб как в примере. 
    //подскажите, пожалуйста, как можно поставить запятую, чтобы она не писалась после последней цифры.
    }
}
Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray (m,n, min,max);
Show2Darray(myArray);
AvgColumns(myArray);
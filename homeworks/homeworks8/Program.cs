// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void Desc(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
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
Console.WriteLine();
Desc(myArray);
Show2Darray(myArray);

*/

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MinRowSum (int [,] array)

{   int row = 0;
    int minSum = 0;
    for(int i=0; i < array.GetLength(0);i++)
    { 
        int sum = 0;
        for(int j=0; j<array.GetLength(1);j++)
        {
            sum = array[i,j] + sum;
        }
        if(i==0)
           {minSum = sum;}
        else if (sum<minSum)
            {minSum = sum;
            row=i;}
        Console.WriteLine($"сумма элементов в строке {i+1} -> {sum}");  
              
    }Console.Write($"Cтрока с наименьшей суммой элементов -> {row+1}");  
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
MinRowSum(myArray);

*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


Console.WriteLine("Введите диапазон случайных чисел: от 0 до ");
int range = Convert.ToInt32(Console.ReadLine());
void CreateMatrix(int [,] array)
    {
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}
void ShowMatrix (int[,] array )
{
    for(int i = 0;i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }    
}
void Multiplycation(int[,] firstMartrix, int[,] secondMartrix, int[,] resMatrix)
{
  for (int i = 0; i < resMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resMatrix[i,j] = sum;
    }
  }
  
}
Console.WriteLine($"размер матрицы");
Console.WriteLine($"Введите число строк 1-ой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число столбцов 1-й матрицы (и строк 2 матрицы)");
int n =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов 2-й матрицы ");
int c = Convert.ToInt32(Console.ReadLine());
int[,] firstMartrix = new int[m, n];
CreateMatrix(firstMartrix);
ShowMatrix(firstMartrix);
Console.WriteLine();
int[,] secondMartrix = new int[c, n];
CreateMatrix(secondMartrix);

ShowMatrix(secondMartrix);
Console.WriteLine();
int[,] resultMatrix = new int[m,n];
Multiplycation(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение матриц:");
ShowMatrix(resultMatrix);


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

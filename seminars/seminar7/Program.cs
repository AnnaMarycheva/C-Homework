//**Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 4 8 19
//5 -2 33 -2
//77 3 8 1

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

//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
//МЕТОД БУДЕТ ЗАПОЛНЯТЬ МАССИВ, на вход будет брать размер массива
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5




//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81** 2 **9**
//8 4 2 4




//Задача 4. адайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

/*
int[] CreateNewArray(int size)
{
    int[] myArray = new int[size];
    for(int i=0; i < size; i++)
    {
        Console.WriteLine($"ВВедите {i+1} элемент ");
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return myArray;
}

void ShowArray(int[] array)
{
    Console.Write("Массив ->  ");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void CountElements(int[] array)
{
    int count=0;
    for (int i=0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }  
    Console.Write($"Количество элементов массива больше нуля -> {count}");
}
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateNewArray(a);
ShowArray (myArray);
Console.WriteLine("");
CountElements(myArray);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(int b1, int k1, int b2, int k2)
{   
    int x=(k1-k2)/(b1 - b2);
    int y = k1*x-b1;
        
    Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
}
Console.WriteLine("ВВедите b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint (b1, k1, b2, k2);






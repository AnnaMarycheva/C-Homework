// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.Write("Массив ->  ");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void EvenNumbers (int[] array)
{
    Console.Write("Четные числа массива ->  ");
    for(int i=0; i < array.Length; i++)
        
    if(array[i]%2 == 0)
    
    Console.Write(array[i] + " " );
    
    else Console.WriteLine($"четных чисел в массиве нет");
    //планировала вывести сроку вывода, 
    //когда нет четных чисел в массиве. Но опять запуталась в скобках. Подскажите, пожалуйста, 
    //как они должны стоять. Этот момент совсем не усвоился, расставляю их в задачах методом научного тыка.
    //в итоге получилось сделать, но понимания все равно не случилось.
}
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите максимальное значение элемента ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray (myArray);
Console.WriteLine("");
EvenNumbers(myArray);

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


/*
int[] CreateRandomArray (int size, int minValue, int maxValue) 
//int почему то все время подчеркивает красным. 
//подскажите, пожалуйста, почему, что не так написала.
{
    int[] myArray = new int[size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.Write("Массив ->  ");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void EvenNumbers (int[] array)
{
    int sumEvenNum = 0;
    for(int i=0; i < array.Length; i++)
        
    if(array[i]%2 == 0) 
    {sumEvenNum = sumEvenNum + array[i];

    Console.Write($"Сумма четных чисел массива {sumEvenNum}");}
    
    else Console.WriteLine($"четных чисел в массиве нет");
    
}
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите максимальное значение элемента ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray (myArray);
Console.WriteLine("");
EvenNumbers(myArray);
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//вариант с int

/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.Write("Массив ->  ");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void MaxMin (int[] array)
{   
    int max = array[1];
    int min = array[0];
    int maxMin = max-min;
    for(int i=2; i < array.Length; i++)
    { 
        
        if(array[i] > max)
            {
            max = array[i];
            }
            else 
                if(array[i] < min);          

                min = array[i];
     
    } 
    maxMin = max-min;  
    Console.WriteLine($"Разница между максимальным и минимальным числом равна {maxMin}");
} 
  
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите максимальное значение элемента ");
int max1 = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min1, max1);
ShowArray (myArray);
Console.WriteLine("");
MaxMin(myArray);
*/

//вариант с double

double [] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] myArray = new double[size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue +1);
    }
    return myArray;
}

void ShowArray (double[] array)
{
    Console.Write("Массив ->  ");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}

void MaxMin (double[] array)
{   
    double max = array[1];
    double min = array[0];
    double maxMin = max-min;
    for(int i=2; i < array.Length; i++)
    { 
        
        if(array[i] > max)
            {
            max = array[i];
            }
            else 
                if(array[i] < min);          

                min = array[i];
     
    } 
    maxMin = max-min;  
    Console.WriteLine($"Разница между максимальным и минимальным числом равна {maxMin}");
} 
  
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите максимальное значение элемента ");
int max1 = Convert.ToInt32(Console.ReadLine());
double [] myArray = CreateRandomArray(a, min1, max1);
ShowArray (myArray);
Console.WriteLine("");
MaxMin(myArray);

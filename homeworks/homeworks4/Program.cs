// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*
int Exponentiation (int num1, int num2)
{
    int result = 1;
    for(int i=1;i <= num2; i++)
    {
        result=result*num1;
    }
    return result;
}
Console.WriteLine("Input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Exponentiation (num1,num2);
Console.WriteLine($"Число {num1} возведенное в степень {num2} -> {result}.");
*/

//или

/*
double Exponentiation (double num1, double num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}
Console.WriteLine("Input num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double result = Exponentiation (num1,num2);
Console.WriteLine($"Число {num1} возведенное в степень {num2} -> {result}.");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*
int SumNum (int num)
{
    int sum = 0;
    
    while(num>0)
    {
        sum = sum+num%10;
        num=num/10;
    }
    return sum;
}
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = SumNum (num);
Console.WriteLine($"Сумма цифр в числе {num} равняется {result}.");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

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
    Console.WriteLine("Массив ->  .");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
}
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите максивальное значение элемента ");
int max = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(a, min, max);
ShowArray (myArray);
*/

//или второй вариант с заданными числами массива не получилось сделать.( числа запрашивает, но не выводит их. 
//Не смогла самостоятельно разобраться, что не так.
/*
int[] CreateArray (int size, int num1, int num2, int num3, int num4, int num5, int num6, int num7, int num8)
{
    int[] myArray = new int[size];
    for(int i=0; i<size; i++)
    {
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

void ShowArray (int[] array)
{   
    int a = Convert.ToInt32(Console.ReadLine());
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());
    int num4 = Convert.ToInt32(Console.ReadLine());
    int num5 = Convert.ToInt32(Console.ReadLine());
    int num6 = Convert.ToInt32(Console.ReadLine());
    int num7 = Convert.ToInt32(Console.ReadLine());
    int num8 = Convert.ToInt32(Console.ReadLine());
 
    Console.Write(array[a]);      
    
}
Console.WriteLine("ВВедите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый элемент ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй элемент ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третий элемент ");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите четвертый элемент ");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пятый элемент ");
int num5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите шестой элемент ");
int num6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите седьмой элемент ");
int num7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите восьмой элемент ");
int num8 = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateArray(a, num1, num2, num3, num4, num5, num6, num7, num8);
ShowArray (myArray);
*/
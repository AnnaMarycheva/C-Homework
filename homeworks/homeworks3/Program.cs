//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*void Palindrom (int num)
{
        int first = num / 10000;
        int last = num % 10;
        int second = num / 1000;
        int secondlast = num % 100;
        if (first == last && second == secondlast)
        Console.WriteLine("Число {num} палиндром");
        else 
        Console.WriteLine("Число {num} НЕ палиндром");
    }
Console.Write("ВВедите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);*/




//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Distance3D (double xa, double ya, double za, double xb, double yb, double zb)
{
return Math.Sqrt (Math.Pow(xa-xb,2)+Math.Pow(ya-yb,2)+Math.Pow(za-zb,2));
}
Console.WriteLine("Input xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input za: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input xb: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zb: ");
double zb = Convert.ToDouble(Console.ReadLine());
double result = Distance3D(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками в 3D пространстве = {result}");
*/



//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cube (int num)
{
        int step = 1;
    
while (step <= num) 
{
    Console.WriteLine($" куб числа {step} равен {step*step*step}");

step++;}
}
Console.WriteLine("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);


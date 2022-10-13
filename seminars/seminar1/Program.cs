/*
Console.Write("input first number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"My first number is {num}");
*/
/*
Console.WriteLine("Input number ");
int num = Convert.ToInt32 (Console.ReadLine());
int result = num * num;
Console.WriteLine($"Кадрат {num} -> {result}");
*/
/*
Console.WriteLine("Input number ");
int num = Convert.ToInt32 (Console.ReadLine());
int current = num * (-1);
while (current <= num) 
{
    Console.Write(current + " ");
    current++;
}
*/
/*
Console.WriteLine("ВВедите трехзначное число ");
int num = Convert.ToInt32 (Console.ReadLine());
int current = num % 10;
Console.Write(current);
*/

Console.WriteLine("input first number ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("input second number ");
int num2 = Convert.ToInt32 (Console.ReadLine());
int quad2 = num2 * num2;
if ( num1 == quad2)
   Console.WriteLine($"{num1} является квадратом {num2}");
else Console.WriteLine($"{num1} не является квадратом {num2}");
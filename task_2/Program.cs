Console.Write("Введи первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double max = 0;

if (num1 >= num2) max = num1;
else if (num2 > num1) max = num2;
if (num3 > max)
{
    max = num3;
    Console.WriteLine("\nмаксимальное число: " + max);
} 
else Console.WriteLine("\nмаксимальное число: " + max);
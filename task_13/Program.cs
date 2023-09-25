// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

//создаю метод, чтобы попрактиковаться
int FindThird(int arg)
{
    int result = 0;

    if (arg > 99 && arg < 1000 || arg < -99 && arg > -1000)
    {
        result = arg % 10;
    }
    else if (arg >= 1000 || arg <= -1000)
    {
        while (arg >= 1000)
        {
            arg = arg / 10;
        }
        result = arg % 10;
    }
    if (result < 0) result = result * -1;
    return result;
}

if (num1 > 99 || num1 < -99) Console.WriteLine($"третья цифра числа {num1} -> {FindThird(num1)}");
else Console.WriteLine(num1 + " - это двузначное число");

if (num2 > 99 || num2 < -99) Console.WriteLine($"третья цифра числа {num2} -> {FindThird(num2)}");
else Console.WriteLine(num2 + " - это двузначное число");

if (num3 > 99 || num3 < -99) Console.WriteLine($"третья цифра числа {num3} -> {FindThird(num3)}");
else Console.WriteLine(num3 + " - это двузначное число");
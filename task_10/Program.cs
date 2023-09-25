// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введи трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи еще трехзначное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи еще трехзначное число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

//Хочу создать метод, чтоб попрактиковаться
int FindSecond(int arg)
{
    int result = (arg / 10) % 10;
    return result;
}

Console.WriteLine($"вторая цифра числа {num} -> {FindSecond(num)}");
Console.WriteLine($"вторая цифра числа {num2} -> {FindSecond(num2)}");
Console.WriteLine($"вторая цифра числа {num3} -> {FindSecond(num3)}");
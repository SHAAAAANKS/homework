Console.Clear();
Console.WriteLine("Является ли твое число четным?\n");
Console.Write("Введи его: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0) Console.WriteLine("Это вообще ноль");

else if (num % 2 == 0)
{
    Console.WriteLine("Это четное число");
}

else Console.WriteLine("Это НЕчетное число");


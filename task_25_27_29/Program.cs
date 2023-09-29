// Задания №25, №27, №29
ConsoleKeyInfo keyInfo;
start:
Console.Write("\nВведите номер задания(25, 27 или 29): ");
int task = Convert.ToInt32(Console.ReadLine());

//метод для возвращения к началу программы


switch (task)
{



    case 25:
        //Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
        Console.Write("Введите число, которое хотите возвести в степень: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("В какую степень, Вы хотите возвести число " + num1 + " ? ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num2 < 0) num2 *= -1;
        Console.WriteLine($"{num1} в степени {num2} = {Math.Pow(num1, num2)}");

        Console.WriteLine("Хотите проверить другие задания? нажмите Y если да или любую другую, чтобы выйти");
        keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Y) goto start;

        else break;

    //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    case 27:
        Console.WriteLine("Введите число, а я посчитаю сумму цифр, из которых оно состоит: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine(sum);

        Console.WriteLine("Хотите проверить другие задания? нажмите Y если да или любую другую, чтобы выйти");
        keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Y) goto start;

        else break;


    //программа, которая задаёт массив из 8 элементов и выводит их на экран.
    case 29:
        Console.WriteLine("Какого размера массив вы хотите получить? ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Задайте минимальное число диапазона: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Задайте максимальное число диапазона: ");
        int max = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max + 1);
        }
        //метод для вывода массива
        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        PrintArray(array);
        Console.WriteLine("Хотите проверить другие задания? нажмите Y если да или любую другую, чтобы выйти");
        keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Y) goto start;

        else break;



    default:
        Console.WriteLine("это нам не задавали");
        goto start;

}

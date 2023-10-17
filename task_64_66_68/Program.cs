Console.WriteLine("Здравствуйте, Иван!");
start:
Console.Write("Введите номер задания(64, 66 или 68): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{


    // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    // N = 5 -> "5, 4, 3, 2, 1"
    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
    case 64:

        Console.Write("Введите N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        void RecurseRangeN (int n)
        {
            if (n < 1) 
            {
                Console.WriteLine();
            }
            else
            {
            Console.Write(n + " ");
            RecurseRangeN(n-1);
            }
        }
        RecurseRangeN(N);

    break;

    case 66:
        // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120
        // M = 4; N = 8. -> 30
        Console.Write("Введите M: ");
        int M2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите N: ");
        int N2 = Convert.ToInt32(Console.ReadLine());

        int RecurseSumRange (int m, int n)
        {
            int sum = m;
            if (m == n) return sum;
            m +=1;
            return sum+= RecurseSumRange(m,n);

        }
        Console.WriteLine(RecurseSumRange(M2,N2));

    break;

    case 68:
    // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 9
    // m = 3, n = 2 -> A(m,n) = 29

    Console.Write("Введите m: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите n: ");
        int num2 = Convert.ToInt32(Console.ReadLine());


    break;

    default:
        Console.WriteLine("это нам не задавали");
    goto start;
}
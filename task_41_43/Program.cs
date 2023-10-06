Console.Write("Введите номер задания: ");
int task = Convert.ToInt32(Console.ReadLine());
switch (task)
{

    case 41:

        Console.Write("Введите нужное количество чисел: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[n];

        //заполние массива случайными числами
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = new Random().Next(-20, 21);
        }

        //подсчет натуральных чисел в массиве
        int count = 0;
        foreach (int num in nums)
        {
            if (num > 0) count++;
        }

        //вывод массива
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //вывод счетчика
        Console.WriteLine("чисел больше нуля - " + count);
        break;

    case 43:

        Console.Write("Введите b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите k1: ");
        int k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите k2: ");
        int k2 = Convert.ToInt32(Console.ReadLine());

        //y = k1 * x + b1, y = k2 * x + b2



    default:
        break;
}

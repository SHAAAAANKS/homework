Console.Write("Введите номер задания(41/43): ");
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
        //честно говоря, я, кажется, забыл вообще всю математику и до сих пор не понимаю как работают формулы, которые я использовал

        Console.Write("Введите b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        Console.WriteLine(x);
        
        double y = k1 * x + b1;

        Console.WriteLine(y);

        //b1 = 2, k1 = 5, b2 = 4, k2 = 9
        //y = k1 * x + b1, y = k2 * x + b2

        Console.WriteLine( $"({x}; {y})");
        break;


    default:
        break;
}

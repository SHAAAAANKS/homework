Console.Write("Введи первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введи второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2) Console.WriteLine("число " + num1 + " больше чем число " + num2 );
else if (num1 < num2) Console.WriteLine("число " + num2 + " больше чем число " + num1 );
else Console.WriteLine("число " + num1 + " равно числу " + num2 );
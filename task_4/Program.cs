Console.Clear();
Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter_plus = 2;
int counter_minus = -2;
// для положительных чисел
if (num >= 2) 
{
    do {
    Console.Write(counter_plus + " ");
    counter_plus = counter_plus + 2;
} while (counter_plus <= num);
}
//для отрицательных чисел
else if (num <= -2)
{
    do{
        Console.Write(counter_minus + " ");
        counter_minus = counter_minus - 2;
    } while (counter_minus >= num);
}
//для неправильных чисел
else Console.Write("В указаном диапазоне нет четных чисел(");
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру, обозначающую день недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday < 0 || weekday > 7) Console.WriteLine("в неделе только 7 дней...");
else if (weekday < 6) Console.WriteLine("Это будний день((");
else if (weekday > 5) Console.WriteLine("Это выходной!!))");
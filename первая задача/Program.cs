// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
    Console.Write("максимальное число");
    Console.WriteLine(number1);
    Console.Write("минимальное число");
    Console.WriteLine(number2);
}
else
{
    Console.Write("максимальное число");
    Console.WriteLine(number2);
    Console.Write("минимальное число");
    Console.WriteLine(number1);
}
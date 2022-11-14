//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine();

System.Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine();

int max = number1;

if(number2 > max)
{
    max = number2;
}
Console.WriteLine($"максимальное число из двух: {max}");
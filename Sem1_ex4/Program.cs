//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 3 числа:");

int[] array = new int [3];

int max = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if(array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine($"максимальный элемент = {max}");
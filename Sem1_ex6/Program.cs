﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int EnterNumber()
{
    int result = int.Parse(Console.ReadLine());
    return result;
}
int num = EnterNumber();
if(num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
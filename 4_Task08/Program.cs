﻿// Задача 8:
// Напишите программу, которая
// на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Решение. Вариант 1

Console.WriteLine("Введите любое число");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;

Console.Write($"Чётные числа диапазона от 1 до {num}: ");

while (count <= num)
{
    Console.Write(count +" ");
    count = count + 2;
}



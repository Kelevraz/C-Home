﻿// Задача 15: Напишите программу, которая
// принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, где 1 - это понедельник, а 7 - воскресенье");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
{
    Console.WriteLine(Day(number) ? "нет" : "да");

bool Day(int number)
{
    return number >= 1 && number <= 5;
}
}
else
{
    Console.WriteLine("Введено некорректное число");
}
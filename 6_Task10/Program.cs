﻿// Задача 10: Напишите программу, которая
// принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите любое трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDit = (number / 10) % 10;

Console.WriteLine($"{secondDit}");
﻿// Задача 23
// Напишите программу, которая
// принимает на вход число (N)
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Numb(int n1)
{
int counter = 1;
while(counter <= n1)
{
Console.WriteLine($"{counter, 3} {counter * counter * counter, 3}");
counter++;
}
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while(number < 1)
{
System.Console.WriteLine("Введите положительное, целое число");
number = Convert.ToInt32(Console.ReadLine());
}

Numb(number);
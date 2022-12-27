// Задача 13: Напишите программу, которая
// выводит третью цифру
// заданного числа
// или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// int number = new Random().Next();
//Console.WriteLine($"Случайное число => {number}");

Console.WriteLine("Введите случайное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Случайное число => {number}");
int digit = number % 10;

while (number >= 1000)
	{
		number = number / 10;
	}

if (number < 100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры");
}

else if (number >= 100 && number <= 999)
{
	Console.WriteLine($"Число => {digit}");
}
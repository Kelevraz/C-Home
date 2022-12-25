// Задача 13: Напишите программу, которая
// выводит третью цифру
// заданного числа
// или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций
// (целочисленное деление, остаток от деления).

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number = new Random().Next();
Console.WriteLine($"Число => {number}");

// bool Three(int number)
// {
//     return number > 99 && number < 1000;
// }

if (number > 999)
{
    while ({number} / 10);
}
else if (number < 100)
{
    Console.WriteLine($"В числе {number} нет третьей цифры");
}
else{
    Console.WriteLine($"Третья цифра числа {number} => {digit}");
}
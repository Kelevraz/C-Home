// Задача 27: Напишите программу, которая
// принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InsertDigit(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int num)
{
    int result = 0;
    
    while (num > 0) 
        {
            int num2 = num % 10;
            result = result + num2;
        }
    return result;
}

int userNumber = InsertDigit("Введите любое число");
int total = Sum(userNumber);
Console.WriteLine($"Сумма всех цифр числа {userNumber} = {total}");
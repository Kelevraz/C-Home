// Задача 25: Напишите цикл, который
// принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InsertDigitA(string textA)
{
    Console.WriteLine(textA);
    int resultA = Convert.ToInt32(Console.ReadLine());
    return resultA;
}

int InsertDigitB(string textB)
{
    Console.WriteLine(textB);
    int resultB = Convert.ToInt32(Console.ReadLine());
    return resultB;
}

int Power(int a, int b)
{ 
    for(int i = 1; i < b; i++)
    
        a = a * b;
    return a;
}

int userNumberA = InsertDigitA("Введите число A");
int userNumberB = InsertDigitB("Введите число B");
int total = Power(userNumberA);
Console.WriteLine($"Число {userNumberA} в степени {userNumberB} = {total}");
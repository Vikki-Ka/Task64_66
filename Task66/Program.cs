/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30     */

int GetUserData(string massage)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return UserData;
}

int GetSumNumber(int start, int end)
{
    int sum = start;
    if (start == end) return sum;
    return sum + GetSumNumber(start + 1, end);
}

int M = GetUserData("Ввидите число М: ");
int N = GetUserData("Ввидите число N: ");
int sum = GetSumNumber(M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} равна = {sum}");

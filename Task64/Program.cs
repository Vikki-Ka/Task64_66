/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetUserData(string massage)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return UserData;
}

void GetRange(int N)
{
    if (N == 0) 
    { 
        Console.Write("\b" + "\b" + " ");
        return;
    }
    Console.Write(N + ", ");
    GetRange(N-1);
}

int N = GetUserData("Ввидите N:");
GetRange(N);
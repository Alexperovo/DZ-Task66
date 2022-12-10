// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 1 число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Numbers (int M, int N)
{
    int rez = M;
    if (M == N)
    return 0;
    else
    {
        M++;
        rez = M + Numbers(M, N);
        return rez;
    }
}
Console.Write(Numbers (M - 1, N));
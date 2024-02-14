///Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите натуральное число: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine()!);
void NaturalNumber(int m, int n)
{
    if (m <= n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
}
NaturalNumber(m, n);
///Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

Console.Write($"Введите чётное натуральное число (N): ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write($"Введите чётное натуральное число (M): ");
int n = Convert.ToInt32(Console.ReadLine()!);
void EvenNaturalNumber(int m, int n)
{
    if (m > n)
        return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    EvenNaturalNumber(m + 1, n);

}
EvenNaturalNumber(m, n);
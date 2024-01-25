Console.Write("Введите число из отрезка [10, 99]: ");

int number = Convert.ToInt32(Console.ReadLine());
int firstnumber = number / 10;
int secondnumber = number % 10;
int maxDigit = firstnumber > secondnumber ? firstnumber : secondnumber;

Console.WriteLine(maxDigit);
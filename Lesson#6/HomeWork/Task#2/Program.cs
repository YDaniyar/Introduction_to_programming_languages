﻿{
    static void Main(string[] args)
    {
        // Входная строка со смешанными буквами обоих регистровstring input = "aBcD1ef!-";
        // Преобразование всех заглавных букв в строчные
        string result = input.ToLower();
        // Вывод результата
        Console.WriteLine(result);
    }
}
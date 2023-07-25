// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8
int num = new Random().Next(10, 100);
string NumStr = num.ToString();

if (NumStr[0] > NumStr[1]) Console.WriteLine($"Наибольшая цифра числа {num} это цифра {NumStr[0]}");
else Console.WriteLine($"Наибольшая цифра числа {num} это цифра {NumStr[1]}");
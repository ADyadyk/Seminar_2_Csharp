// Задача 2. Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

Console.Write("Введите число a=");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b=");
int b = int.Parse(Console.ReadLine()!);

if (a%b == 0) Console.WriteLine($"Число {a} кратно {b}");
else 
{
    Console.WriteLine($"Число {a} не кратно {b}");
    int remainder = a % b;
    Console.WriteLine($"Остаток от деления {a} на {b} равен {remainder}");
}
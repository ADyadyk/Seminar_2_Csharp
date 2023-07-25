// Задача 4. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.Write("Введите число a=");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b=");
int b = int.Parse(Console.ReadLine()!);

int sqra = Convert.ToInt32(Math.Pow(a, 2));
int sqrb = Convert.ToInt32(Math.Pow(b, 2));

if (a == sqrb) Console.Write($"Число a={a} является квадратом числа b={b}");
if (b == sqra) Console.Write($"Число b={b} является квадратом числа a={a}");
if (b != sqra && a != sqrb) Console.Write($"Число a не является квадратом числа b. И число b не является квадратом числа a.");

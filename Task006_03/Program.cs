/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. (Если решаете математически
через рандом, то проверка не нужна на трехзначность. Если через строки, то она
обязательна)
456 -> 5
782 -> 8
918 -> 1
*/

//Решение с применением методов

//Добавим метод, который запрашивает у пользователя трёхзначное число

int PutNumber(string message)
{
    Console.WriteLine(message);
    string a = Console.ReadLine();
    int result = int.Parse(a);
    return result;
}

//Добавим метод, который проверяет число на трёхзначность

bool CheckNumber(int someNumber)
{
    if (someNumber > 100 && someNumber <999)
    {
        Console.WriteLine($"Введено трёхзначное число {someNumber}");
        return true;
    }
    else
    {
        return false;
    }
}

//Добавим метод, который непосредственно ищет вторую цифру трёхзначного числа

int FindSecondRank(int threeDigitNumber)
{
    int secondRankNumber = (threeDigitNumber/10)%10;
    return secondRankNumber;
}

//Непосредственно программа

int number = PutNumber("Введите трёхзначное число: ");

if (CheckNumber(number))
{
    Console.WriteLine($"Вторая цифра {FindSecondRank(number)}");
}
else
{
    Console.WriteLine($"Введено не трёхзначное число {number}");
    number = PutNumber("Введите ещё раз число (трёхзначное): ");
    if (CheckNumber(number)) 
    {
        Console.WriteLine($"Вторая цифра {FindSecondRank(number)}");
    }
    else Console.WriteLine("Вы опять ввели не правильно!");
}
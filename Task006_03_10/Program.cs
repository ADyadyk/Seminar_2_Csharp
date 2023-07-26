/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа. (Если решаете математически
через рандом, то проверка не нужна на трехзначность. Если через строки, то она
обязательна)
456 -> 5
782 -> 8
918 -> 1
*/

//Решение с применением методов (+метод вывода второй цифры) (+десять попыток ввода)

//Добавим метод, который запрашивает у пользователя трёхзначное число

int PutNumber(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
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


//Метод вывода результата с 10 попытками ввода

void PrintSecondRank(int putNumber)
{
    int count = 1;

    while (count < 10)
    {
        if (CheckNumber(putNumber))
        {
            Console.WriteLine($"Вторая цифра {FindSecondRank(putNumber)}");
            break;
        }
        else
        {
            Console.WriteLine("Введено не трёхзначное число.");
        }
        Console.WriteLine($"У вас осталось {10 - count} попыток.");
        putNumber = PutNumber("Введите трёхзначное число ещё раз: ");
        count++;
    }
}


//Непосредственно программа

int number = PutNumber("Введите трёхзначное число: ");
PrintSecondRank(number);
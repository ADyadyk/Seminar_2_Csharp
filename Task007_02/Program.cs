/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. (Если решаете математически максимум берем 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//Решение математическое


//Добавим метод, который запрашивает у пользователя число

int PutNumber(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Метод, матаматически выводящий третью цифру

void GiveThirdRangNum(int n)
{
    if (n < 100)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        int count = 100;
        while (count <= n)
        {
            if (n/count < 10)
            {
                int del = count / 100;
                int Third = (n/del)%10;
                Console.WriteLine($"Третья цифра числа {n} равна {Third}");
                break;
            }
            else
            {
                count = count*10;
            }
        }
    }
}

//Сама программа

int Number = PutNumber("Введите число: ");
GiveThirdRangNum(Number);
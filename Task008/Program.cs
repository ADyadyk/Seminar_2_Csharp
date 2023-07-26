/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. 
(Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
6 -> да
7 -> да
1 -> нет
*/

// Метод запроса номера дня недели у пользователя

int PutWeekDay(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

//Метод, проверяющий существует ли такой день недели

void ValidateWeekDay(int someDay)
{
    if (someDay < 1 || someDay >7)
    {
        Console.WriteLine("Ошибка! Дня с таким порядковым номером не существует.");
    }
}

//Метод, определяющий какой это день недели

string GiveWeekDay(int day)
{
    string[] weekDays= {
        "Понедельник",
        "Вторник",
        "Среда",
        "Четверг",
        "Пятница",
        "Суббота",
        "Воскресенье"
    };
    string weekDay = weekDays[day - 1];
    return weekDay;
}

//Метод, определяющий выходной ли это

void IsItHoliday(string someWeekDay)
{
    if (someWeekDay == "Суббота" || someWeekDay == "Воскресенье")
    {
        Console.WriteLine($"Сегодня {someWeekDay}");
        Console.WriteLine("Сегодня выходной!");
    }
    else
    {
        Console.WriteLine($"Сегодня {someWeekDay}");
        Console.WriteLine("Сегодня будний день...");
    }
}


//Непосредственно сама программа

int numberDay = PutWeekDay("Введите номер дня недели: ");
ValidateWeekDay(numberDay);
IsItHoliday(GiveWeekDay(numberDay));
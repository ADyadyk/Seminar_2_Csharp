/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным. 
(Проверка выхода за пределы значений недели, т.е. < 1 и > 7)
6 -> да
7 -> да
1 -> нет
*/

/*
С использованием конструкции 

switch (switch_on)
{
    
    default:
}
*/

// Метод запроса номера дня недели у пользователя

int PutWeekDay()
{
    Console.Write("Введите номер дня недели: ");
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
/*
Метод, проверяющий:
1. существует ли такой день недели
2. дающий информацию какой это день недели
3. дающий информацию выходной ли это
*/

void ValidGiveWeekDayIsItHoliday(int nDay)
{
    switch (nDay)
    {
        case 1:
            Console.WriteLine($"Это понедельник - будний день.");
            break;
        case 2:
            Console.WriteLine($"Это вторник - будний день.");
            break;
        case 3:
            Console.WriteLine($"Это среда - будний день.");
            break;
        case 4:
            Console.WriteLine($"Это четверг - будний день.");
            break;
        case 5:
            Console.WriteLine($"Это пятница - будний день.");
            break;
        case 6:
            Console.WriteLine($"Это суббота - выходной день!");
            break;
        case 7:
            Console.WriteLine($"Это воскресенье - выходной день!");
            break;
        default:
            Console.WriteLine($"Дня недели с порядковым номером {nDay} не бывает!!");
            break;
    }
}

//Непосредственно сама программа

int numberDay = PutWeekDay();
ValidGiveWeekDayIsItHoliday(numberDay);

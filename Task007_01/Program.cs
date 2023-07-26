/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. (Если решаете математически максимум берем 100000)
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//Решение через преобразование в строку заданного числа


//Добавим метод, который запрашивает у пользователя число

string PutNumber(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

//Метод, который проверяет что длина массива строки больше 3 и выводит третью цифру

void GiveThirdRang(string nstr)
{
    if (nstr.Length >= 3)
    {
        Console.WriteLine($"Третья цифра числа {nstr} равна {nstr[2]}");
    }
    else
    {
        Console.WriteLine($"Третьей цифры в числе {nstr} нет.");
    }
}

//Сама программа

string strNumber = PutNumber("Введите число: ");
GiveThirdRang(strNumber);
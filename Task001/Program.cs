//Разбирала преподаватель:

int num = new Random().Next(1000);
string NumStr = num.ToString();

if (NumStr.Length == 3)
{
    Console.WriteLine($"Число {num} без второй цифры имеет вид {NumStr[0]}{NumStr[2]}");
}
else
{
    Console.WriteLine($"Число {num} не трёхзначное");
}
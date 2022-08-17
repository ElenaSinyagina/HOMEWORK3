// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

if (number < 0)
{
    number = number * (-1);
}

if (number < 100000 && number > 9999)
{
    int x1 = number / 10000;
    int x2 = number / 1000 - x1 * 10;
    int x3 = number / 100 - (x1 * 100 + x2 * 10);
    int x5 = number%10;
    int x4 = (number%100 - x5)/10;
    if (x1 == x5 && x2 == x4)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}

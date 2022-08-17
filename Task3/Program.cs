// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
string? numberString = Console.ReadLine();

int N = int.Parse(numberString);

int index = 1;

if (N < 0)
{
    N = N * (-1);
}

while(N >= index)
{
    var result = Math.Pow(index, 3);
    index++;
    Console.WriteLine(result);
}
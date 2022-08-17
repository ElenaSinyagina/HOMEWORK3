// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты Х первой точки:");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y первой точки:");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Z первой точки:");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Х второй точки:");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Y второй точки:");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты Z второй точки:");
int z2 = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));

Console.WriteLine("\n" + AB.ToString("N2"));
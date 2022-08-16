// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите значение X1: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Z1: ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение X2: ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Z2: ");
double z2 = double.Parse(Console.ReadLine());

double xyz = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

Console.WriteLine($"Расстояние между точками в 3D пространстве: {Math.Round(xyz, 2)}");
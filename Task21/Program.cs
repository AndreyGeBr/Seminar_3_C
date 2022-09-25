// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
Console.Clear();

Console.WriteLine("Введите координаты точки А: ");
Console.Write("x: ");
int xa = int.Parse(Console.ReadLine());

Console.Write("y: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("x: ");
int xb = int.Parse(Console.ReadLine());

Console.Write("y: ");
int yb = int.Parse(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
s = Math.Round(s, 2);

Console.WriteLine($"Расстояние равно {s:f2}");
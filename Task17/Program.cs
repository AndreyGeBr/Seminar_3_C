//Программа, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();

Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());

/* Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"A({x}, {y})"); */

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка лежит в первой четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка лежит во второй четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка лежит в третьей четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка лежит в четвертой четверти");
}
else 
{
    Console.WriteLine("Точка лежит на одной из осей");    
}
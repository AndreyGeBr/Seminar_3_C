// Программа, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();

Console.Write("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("Диапазон возможных координат: x > 0 и y > 0");
}
else if (number == 2)
{
    Console.WriteLine("Диапазон возможных координат: x < 0 и y > 0");
}
else if (number == 3)
{
    Console.WriteLine("Диапазон возможных координат: x < 0 и y < 0 ");
}
else if (number == 4)
{
    Console.WriteLine("Диапазон возможных координат: x > 0 и y < 0");
}
else 
{
    Console.WriteLine("Есть всего 4 четверти. Введите число от 1 до 4");    
}
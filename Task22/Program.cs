// Программа, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

/* int count = 1;
double sqw;

while (count <= n)
{
    sqw = Math.Pow(count, 2);
    Console.WriteLine($"{count} в квадрате равно {sqw} ");
    count++;
} */

int count = 1;
while (count <= n)
{
    Console.Write($"{Math.Pow(count, 2)}");
    if (count != n)
        Console.Write(", ");
    count++;
}


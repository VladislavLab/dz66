// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Addit(int n, int m)
{
    if (n == m) return n;
    return n+Addit(n + 1, m);

}
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(Addit(n,m));

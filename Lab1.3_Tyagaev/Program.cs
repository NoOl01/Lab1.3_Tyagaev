// Лабораторная работа 1-3 задание 3.35

Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());
int n1 = (n / 100 % 10);
int n2 = (n % 100);
int n3 = (n2 * 10 + n1);
Console.WriteLine($"число n = {n3}");
Console.Write("Для проверки введите x: ");
int x = int.Parse(Console.ReadLine());
int x1 = (x / 10 % 100);
int x2 = (x % 10);
int x3 = (x2 * 100 + x1);
Console.WriteLine($"число x = {x3}");
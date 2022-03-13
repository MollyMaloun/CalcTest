int a;
Console.WriteLine("Введите число");
a = int.Parse(Console.ReadLine());
int b = a % 2;
if (a % 2 == 0)
{
    Console.WriteLine($"число четное и равняется {a}");
}
else
{
    Console.WriteLine($"Число не четное и остаток от деления равняется {b}");
}
Console.ReadLine();

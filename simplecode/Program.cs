int euro = 100;
int a;
int end, next;
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine($"rec {a * euro}");
Console.WriteLine("1 - продолжить, 2 - закончить");
int.TryParse(Console.ReadLine(), out end);
if (end < 2)
{
    int.TryParse(Console.ReadLine(), out a);
    Console.WriteLine($"rec {a * euro}");
} 


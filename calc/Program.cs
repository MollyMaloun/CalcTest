int a = int.Parse(Console.ReadLine());
string b = Console.ReadLine();
switch (b)
{
    case "+":
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine(a + c);
        break;
    case "-":
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(a - d);
        break;
    case "*":
        int e = int.Parse(Console.ReadLine());
        Console.WriteLine(a * e);
        break;
    case "/":
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine(a / f);
        break;
    default:
        break;
}
Console.ReadLine();

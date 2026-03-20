Console.WriteLine("=== Tiny Calculator ===");

Console.ForegroundColor = ConsoleColor.Cyan;
int a = TryParse1("Operand 1: ");
int b = TryParse2("Operand 2: ");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a} - {b} = {a - b}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{a} * {b} = {a * b}");
Console.ForegroundColor = ConsoleColor.Green;
if (b == 0)
{ 
    Console.WriteLine($"{a} / {b} = undefied");
}
else
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}
Console.ResetColor();

int TryParse1(string input)
{
    Console.Write("Operand 1: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Invalid input. Please enter an integer.");
        Console.Write("Operand 1: ");
    }
    return a;
}
int TryParse2(string input)
{
    Console.Write("Operand 2: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Invalid input. Please enter an integer.");
        Console.Write("Operand 2: ");
    }
    return b;
}


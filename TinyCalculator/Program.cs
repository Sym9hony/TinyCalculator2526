Console.WriteLine("=== Tiny Calculator ===");

Console.ForegroundColor = ConsoleColor.Cyan;
int a = ReadOperand("Operand 1: ");
int b = ReadOperand("Operand 2: ");
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

static int ReadOperand(string title)
{
    Console.Write($"{title}: ");
    int operand;
    while (!int.TryParse(Console.ReadLine(), out operand))
    {
        Console.WriteLine($"FEHLER: {title} ist keine Zahl");
        Console.Write($"{title}: ");
    }

    return operand;
}



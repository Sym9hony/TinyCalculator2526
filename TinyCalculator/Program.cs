Console.WriteLine("=== Tiny Calculator ===");

Console.ForegroundColor = ConsoleColor.Cyan;
int a = ReadOperand("Operand 1: ");
int b = ReadOperand("Operand 2: ");
Console.ResetColor();

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a} - {b} = {a - b}");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{a} * {b} = {a * b}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a} / {b} = {(double)a / b}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{a}: {Faculty(a)}");
Console.WriteLine($"{b}: {Faculty(b)}");
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
int Faculty(int n)
{
    int faculty = 1;
    for (int i = 1; i <= a; i++)
    {
        faculty *= i;
    }
    return faculty;
}


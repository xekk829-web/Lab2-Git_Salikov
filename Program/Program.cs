namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("How are you?");
    }
}

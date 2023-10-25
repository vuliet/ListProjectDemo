public delegate void PrintMessage(string message, string name);

public class Program
{
    static void Main()
    {
        PrintMessage printHello = (message, name) => Console.WriteLine($"{message}, {name}");
        PrintMessage printGoodbye = (message, name) => Console.WriteLine($"{message}, {name}");

        GreetPerson("Hello", "John", printHello);
        GreetPerson("Goodbye", "Alice", printGoodbye);

        Console.ReadLine();
    }

    public static void GreetPerson(string message, string name, PrintMessage printDelegate)
    {
        printDelegate(message, name);
    }
}

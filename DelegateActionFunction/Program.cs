public delegate void PrintMessage(string message);

public class Program
{
    static void Main()
    {
        PrintMessage printHello = (message) => Console.WriteLine($"Hello, {message}");
        PrintMessage printGoodbye = (message) => Console.WriteLine($"Goodbye, {message}");

        GreetPerson("John", printHello);
        GreetPerson("Alice", printGoodbye);

        Console.ReadLine();
    }

    static void GreetPerson(string name, PrintMessage printDelegate)
    {
        printDelegate(name);
    }
}

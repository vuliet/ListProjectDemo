
public delegate int MathOperation(int a, int b);

public class Program
{
    public static int Add(int a, int b)
    {
        Console.WriteLine("Start Add Method");
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        Console.WriteLine("Start Subtract Method");
        return a - b;
    }

    public static void Main()
    {
        MathOperation operation = Add;
        operation += Subtract;

        var invocationList = operation.GetInvocationList();

        var addOperation = invocationList
            .OfType<MathOperation>()
            .FirstOrDefault(x => x.Method.Name == "Add");

        if (addOperation is null)
        {
            Console.WriteLine("Not found Add method");
            Console.ReadLine();
            return;
        }

        int result = addOperation(5, 3);

        Console.WriteLine("Result: " + result);
        Console.ReadLine();
    }
}

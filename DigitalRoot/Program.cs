static int DigitalRoot(int n)
{
    return n == 0 ? 0 : 1 + ((n - 1) % 9);
}

var result = DigitalRoot(1876);

Console.WriteLine($"DigitalRoot result = {result}");
Console.ReadLine();

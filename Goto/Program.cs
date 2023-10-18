var retryCount = 0;

Start:
try
{

}
catch
{
    if (retryCount <= 4)
    {
        retryCount++;
        await Task.Delay(1000);
        goto Start;
    }
    throw;
}

var state = "Pending";

switch (state)
{
    case "Pending":
        Console.WriteLine("Case pending");
        Console.WriteLine("goto case Processing");
        goto case "Processing";
    case "Processing":
        Console.WriteLine("Case Processing");
        break;
    default:
        break;
}

Console.ReadLine();

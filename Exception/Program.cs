using ExceptionTest;

static bool TestException()
{
    throw new AppException("Exception1");
}

static bool MethodCall()
{
    var isException = TestException();

    return isException;
}

static bool MethodCall2()
{
    try
    {
        var isException2 = MethodCall();

        return isException2;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return false;
    }
}

var isException = MethodCall2();

Console.WriteLine($"Exception:{isException}");

Console.ReadLine();
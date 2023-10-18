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

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchmarks>();

public class Benchmarks
{
    private const int Iterations = 100;

    [Benchmark]
    public int For_Loop()
    {
        var count = 0;

        for (int i = 0; i <= Iterations; i++)
        {
            count += i;
        }

        return count;
    }

    [Benchmark]
    public int Goto_Loop()
    {
        var count = 0;
        var i = 0;

    Start:

        if (i <= Iterations)
        {
            count += i;
            i++;
            goto Start;
        }

        return count;
    }
}
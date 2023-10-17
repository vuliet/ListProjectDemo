Thread thread = new Thread(new ThreadStart(DoAsyncWork));
thread.Start();

// Thực hiện công việc khác trên luồng chính
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Main thread: {i}");
    Thread.Sleep(500); // Giả lập công việc mất thời gian
}

// Chờ thread bất đồng bộ hoàn thành
thread.Join();

Console.WriteLine("Main thread finished.");

static void DoAsyncWork()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Async thread: {i}");
        Thread.Sleep(1000); // Giả lập công việc mất thời gian
    }
}

Console.ReadLine();
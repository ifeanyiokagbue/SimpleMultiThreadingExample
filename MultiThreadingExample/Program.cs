// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hello, Browser from the main thread {Thread.CurrentThread.ManagedThreadId}");
RunMultipleThreads();

static void RunSingleThread()
{
    RunMeFirst();
    RunMeSecond();
}

static void RunMultipleThreads()
{
    new Thread(RunMeFirst).Start();
    new Thread(RunMeSecond).Start();
}

static void RunMeFirst()
{
    Console.WriteLine($"Hello from RunMeFirst and Thread {Thread.CurrentThread.ManagedThreadId}");
    for(int i = 0; i < 30000; i++)
    {
        Console.WriteLine($"Ping from RunMeFirst and Thread {Thread.CurrentThread.ManagedThreadId}");
    }
}

static void RunMeSecond()
{
    Console.WriteLine($"Hello from RunMeSecond and Thread {Thread.CurrentThread.ManagedThreadId}");
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Ping {i} from RunMeSecond and Thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
    }
}

using System;

Main();

static void Main()
{
    Console.WriteLine("=== 단순 카운터 ===");
    Func<int> simple = CounterFactory.CreateSimpleCounter();

    for (int i = 0;  i < 5; i++)
    {
        Console.Write($"{simple()} ");
    }

    Console.WriteLine("\n\n=== 스텝 카운터 (step=3) ===");
    Func<int> step = CounterFactory.CreateStepCounter(3);

    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{step()} ");
    }

    Console.WriteLine("\n\n=== 범위 카운터 ===");
    Func<int> bound = CounterFactory.CreateBoundedCounter(1, 3);

    for (int i = 0; i < 7; i++)
    {
        Console.Write($"{bound()} ");
    }

    Console.WriteLine("\n\n=== 리셋 가능 카운터 ===");
    Action action; Func<int> func;
    CounterFactory.CreateResettableCounter(out action, out func);

    Console.Write($"호출: ");

    for (int i = 0; i < 3; i++)
    {
        Console.Write($"{func()} ");
    }

    Console.WriteLine();
    action();

    Console.Write($"리셋 후: ");

    for (int i = 0; i < 2; i++)
    {
        Console.Write($"{func()} ");
    }
}

static class CounterFactory
{
    public static Func<int> CreateSimpleCounter()
    {
        int count = 0;

        return delegate
        {
            count++;
            return count;
        };
    }

    public static Func<int> CreateStepCounter(int step)
    {
        int count = 0;

        return delegate
        {
            count += step;
            return count;
        };
    }

    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = min;

        return delegate
        {
            if (count > max) count = min;
            return count++;
        };
    }

    public static void CreateResettableCounter(out Action action, out Func<int> func)
    {
        int count = 0;

        action = delegate
        {
            count = 0;
        };

        func = delegate { return ++count; };
    }
}
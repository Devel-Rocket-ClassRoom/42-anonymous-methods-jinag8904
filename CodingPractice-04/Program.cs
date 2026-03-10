using System;
using System.Collections.Generic;

// 1.
{
    Calculator anonymous = delegate (int i) { return i * i; };
    Calculator lambda = i => i * i;

    Console.WriteLine($"익명 메서드: {anonymous(4)}");
    Console.WriteLine($"람다식: {lambda(4)}");
}
Console.WriteLine();

// 2.
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine($"짝수: {string.Join(", ", Filter(numbers, delegate (int i) { return i % 2 == 0; }))}");
    Console.WriteLine($"5보다 큰 수: {string.Join(", ", Filter(numbers, delegate (int i) { return i > 5; }))}");

    static List<int> Filter(int[] source, Func<int, bool> predicate)
    {
        List<int> result = new List<int>();

        foreach (int i in source)
        {
            if (predicate(i)) result.Add(i);
        }

        return result;
    }
}
Console.WriteLine();

// 3.
{
    int factor = 10;

    Func<int, int> normalMethod = delegate (int n) { return n * factor; };
    Func<int, int> staticMethod = static delegate (int n) { return n * 2; };

    Console.WriteLine(normalMethod(5));
    Console.WriteLine(staticMethod(5));
}

// 1.
delegate int Calculator(int i);
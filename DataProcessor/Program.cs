using System;
using System.Collections.Generic;

Main();

static void Main()
{
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Func<int, bool> isEven = i => i % 2 == 0;

    Console.Write($"=== 원본 배열 출력 ===\n");
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();

    Console.Write($"\n=== 2배로 변환 ===");
    array = DataProcessor.Transform(delegate (int i) { return i * 2; });
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();

    Console.Write($"\n=== 짝수만 필터링 ===");


}

class DataProcessor
{
    public static void ForEach(Action<int> action)  // 배열의 각 요소에 대해 action 실행
    {
        foreach (int i in ints)
        {
            action(i);
        }
    }

    public static int[] Transform(Func<int, int> transformer)   // 배열의 각 요소를 변환해 새 배열 반환
    {
        int[] newInts = new int[ints.Length];

        foreach (int i in ints)
        {
            newInts[i] = transformer(i);
        }

        return newInts;
    }

    public static List<int> Filter(Func<int, bool> predicate)
    {
        List<int> newInts = new List<int>();

        foreach (int i in ints)
        {
            if (predicate(i)) newInts.Add(i);
        }

        return newInts;
    }

    public static int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int sum = 0;

        foreach (int i in ints)
        {
            sum += i;
        }

        return sum;
    }
}
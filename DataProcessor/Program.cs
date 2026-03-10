using System;
using System.Collections.Generic;

Main();

static void Main()
{
    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };  // 원본 배열
    DataProcessor processor = new DataProcessor(numbers);

    Console.Write($"=== 원본 배열 출력 ===\n");
    processor.ForEach(delegate (int i) { Console.Write($"{i} "); });
    Console.WriteLine();

    Console.Write($"\n=== 2배로 변환 ===\n");
    int[] doubled = processor.Transform(delegate (int i) { return i * 2; });
    foreach (int i in doubled) Console.Write($"{i} ");
    Console.WriteLine();

    Console.Write($"\n=== 짝수만 필터링 ===\n");
    List<int> filtered = processor.Filter(delegate (int i) { return i % 2 == 0; });
    foreach (int i in filtered) Console.Write($"{i} ");
    Console.WriteLine();

    Console.WriteLine($"\n=== 합계 계산 ===");
    int sum = processor.Reduce(delegate (int a, int b) { return a + b; }, 0);
    Console.WriteLine($"합계: {sum}");
}

class DataProcessor
{
    private int[] _ints;

    public DataProcessor(int[] numbers)
    {
        _ints = numbers;
    }

    public void ForEach(Action<int> action)  // 배열의 각 요소에 대해 action 실행
    {
        foreach (int i in _ints)
        {
            action(i);
        }
    }

    public int[] Transform(Func<int, int> transformer)   // 배열의 각 요소를 변환해 새 배열 반환
    {
        int[] newInts = new int[_ints.Length];

        for (int i = 0; i < _ints.Length; i++)
        {
            newInts[i] = transformer(_ints[i]);
        }

        return newInts;
    }

    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> newInts = new List<int>();

        foreach (int i in _ints)
        {
            if (predicate(i)) newInts.Add(i);
        }

        return newInts;
    }

    public int Reduce(Func<int, int, int> reducer, int initialValue)
    {
        int result = initialValue;

        foreach (int i in _ints)
        {
            result = reducer(result, i);
        }

        return result;
    }
}
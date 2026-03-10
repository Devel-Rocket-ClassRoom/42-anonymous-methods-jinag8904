using System;

// 1.
{
    Calculator anonymous = delegate (int i) { return i * i; };
    Calculator lambda1 = i =>
    {
        return i * i;
    };
    Calculator lambda2 = i => i * i;

    Console.WriteLine($"익명 메서드: {anonymous(5)}");
    Console.WriteLine($"람다식 (블록): {lambda1(5)}");
    Console.WriteLine($"람다식 (표현식): {lambda2(5)}");
}
Console.WriteLine();

// 2.
{
    EventHandler handler1 = delegate { Console.WriteLine("이벤트 처리됨"); };
    EventHandler handler2 = (o, e) => Console.WriteLine("이벤트 처리됨");

    handler1(null, EventArgs.Empty);
    handler2(null, EventArgs.Empty);
}
Console.WriteLine();

// 3.
{
    GameEvent onScoreChange = delegate { };
    GameEvent onGameOver = delegate { };

    onScoreChange("점수 변경", 100);
    onGameOver("게임 종료", 0);

    onScoreChange += delegate (string s, int i) { Console.WriteLine($"[이벤트] {s}: {i}"); };
    onScoreChange("점수 변경", 500);
}
Console.WriteLine();

// 4.
{
    int[] numbers = { 1, 2, 3, 4, 5 };
    int sum = 0;

    ProcessData(numbers, delegate (int i)
    {
        sum += i;
        Console.WriteLine($"처리 중: {i}, 누적: {sum}");
    });

    static void ProcessData(int[] data, Action<int> callback)
    {
        foreach (int i in data)
        {
            callback(i);
        }
    }
}
Console.WriteLine();

// 4.

// 3.
delegate void GameEvent(string s, int i);

// 2.
delegate void EventHandler(object o, EventArgs e);

// 1.
delegate int Calculator(int i);
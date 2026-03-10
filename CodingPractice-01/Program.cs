using System;

// 1.
{
    Calculator calc = Square;
    Console.WriteLine(calc(5));

    static int Square(int x) => x * x;
}
Console.WriteLine();

// 2.
{
    Transformer square = delegate (int x) { return x * x; };
    Transformer cube = delegate (int x) { return x * x * x; };

    Console.WriteLine($"3의 제곱: {square(3)}");
    Console.WriteLine($"3의 세제곱: {cube(3)}");
}
Console.WriteLine();

// 3.
{
    Printer printer = delegate (string message) { Console.WriteLine($"[메시지] {message}"); };
    printer("안녕하세요");
    printer("익명 메서드 사용 중");
}
Console.WriteLine();

// 4.
{
    Func<int, int> doubler = delegate (int x) { return x * 2; };
    Action<string> logger = delegate (string s) { Console.WriteLine($"[Log] {s}"); };

    Console.WriteLine(doubler(10));
    logger("작업 시작");
}
Console.WriteLine();

// 5.
{
    SimpleDelegate handler = delegate { Console.WriteLine("매개변수 사용하지 않음."); };
    handler(100, "테스트");
}
Console.WriteLine();

// 6.
{
    EventHandler onClick = delegate { Console.WriteLine("클릭 이벤트 발생"); };
    onClick(null, EventArgs.Empty);
}
Console.WriteLine();

// 6.
delegate void EventHandler(object o, EventArgs e);

// 5.
delegate void SimpleDelegate(int i, string s);

// 3.
delegate void Printer(string s);

// 2.
delegate int Transformer(int i);

// 1.
delegate int Calculator(int i);
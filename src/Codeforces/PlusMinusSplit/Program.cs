using System;
using System.Linq;

/*
* Problem: Plus-Minus Split
* URL: https://codeforces.com/contest/1919/problem/B
* Status: AC
*/
public static class PlusMinusSplit
{
    private static void Solve()
    {
        var n = int.Parse(Console.ReadLine() ?? "0");
        var s = Console.ReadLine();
        var plus = s?.Count(c => c == '+') ?? 0;
        var minus = s?.Count(c => c == '-') ?? 0;
        Console.WriteLine(Math.Abs(plus - minus));
    }
    public static void Main()
    {
        if (!int.TryParse(Console.ReadLine(), out var t))
        {
            Console.WriteLine("Invalid input");
            return;
        }
        for (var i = 0; i < t; i++)
        {
            Solve();
        }
    }
}

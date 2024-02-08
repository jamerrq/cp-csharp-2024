using System;
using System.Linq;

/*
* Problem: Arranging Cats
* URL: https://codeforces.com/contest/1921/problem/B
* Status: AC
*/
public static class ArrangingCats
{
    private static void Solve()
    {
        var n = int.Parse(Console.ReadLine() ?? "0");
        var s = Console.ReadLine() ?? "";
        var t = Console.ReadLine() ?? "";
        int ZeroOne = 0;
        int OneZero = 0;
        for (var i = 0; i < n; i++)
        {
            if (s[i] == '0' && t[i] == '1')
            {
                ZeroOne++;
            }
            else if (s[i] == '1' && t[i] == '0')
            {
                OneZero++;
            }
        }
        Console.WriteLine(Math.Max(ZeroOne, OneZero));
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

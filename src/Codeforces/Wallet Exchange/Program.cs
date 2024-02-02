using System;
using System.Linq;

/*
* Problem: Wallet Exchange
* URL: https://codeforces.com/contest/1919/problem/A
* Status: AC
* Time: 109 ms
* Memory: 460 KB
*/
public static class WalletExchange
{
    private static void Solve()
    {
        string ans = "Bob";
        var sum = Console.ReadLine().Split().Select(int.Parse).Sum();
        if (sum % 2 == 1)
        {
            ans = "Alice";
        }
        Console.WriteLine(ans);
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

using System;
using System.Linq;

/*
* Problem: Wallet Exchange
* URL: https://codeforces.com/contest/1919/problem/A
* Status: AC
*/
public static class WalletExchange
{
    private static void Solve()
    {
        int sum = 0;
        string ans = "Bob";
        foreach (var s in Console.ReadLine().Split())
        {
            sum += int.Parse(s);
        }
        if (sum % 2 == 1)
        {
            ans = "Alice";
        }
        Console.WriteLine(ans);
    }
    public static void Main()
    {
        var t = int.Parse(Console.ReadLine());
        for (var i = 0; i < t; i++)
        {
            Solve();
        }
    }
}

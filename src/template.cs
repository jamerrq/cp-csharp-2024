using System;
using System.Linq;

/*
* Problem: [PROBLEM_NAME]
* URL: [PROBLEM_URL]
* Status: [AC|WA|TLE|RE|CE]
*/
public static class WalletExchange
{
    private static void Solve()
    {
        // Brainstorm here
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

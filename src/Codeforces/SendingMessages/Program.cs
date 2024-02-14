using System;
using System.Linq;
using System.Numerics;

/*
* Problem: Sending Messages
* URL: https://codeforces.com/contest/1921/problem/C
* Status: AC
*/

namespace Problem
{
    public static class SendingMessages
    {
        private static readonly int[] first = { 0 };

        private static void Solve()
        {
            // Pinte seu código aqui
            var input = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray()!;
            var n = input[0];
            var f = input[1];
            var a = input[2];
            var b = input[3];
            var M = Console.ReadLine()?.Split(' ').Select(int.Parse).ToArray()!;
            M = first.Concat(M).ToArray();
            BigInteger F = f;
            for (int i = 1; i < n + 1; ++i)
            {
                int x = M[i] - M[i - 1];
                int d = b;
                if (F / x >= a)
                {
                    d = Math.Min(a * x, b);
                }
                F -= d;
                if (F <= 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
        public static void Main()
        {
            var t = int.Parse(Console.ReadLine() ?? "0");
            for (var i = 0; i < t; i++)
            {
                Solve();
            }
        }
    }

}

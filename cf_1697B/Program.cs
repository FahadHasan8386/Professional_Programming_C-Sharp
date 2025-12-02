using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int q = int.Parse(first[1]);

        long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();

        Array.Sort(v);

        long[] s = new long[n + 1];

        for (int i = 0; i < n; i++)
        {
            s[i + 1] = s[i] + v[i];
        }

        while (q-- > 0)
        {
            var parts = Console.ReadLine().Split();
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);

            long result = s[n - x + y] - s[n - x];

            Console.WriteLine(result);

        }

    }
}
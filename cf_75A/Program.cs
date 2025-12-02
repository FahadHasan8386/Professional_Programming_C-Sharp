using System;

class Program
{
    static long RemoveZero(long num)
    {
        string s = num.ToString();
        string t = "";

        foreach (char c in s)
        {
            if (c != '0')
                t += c;
        }

        return long.Parse(t);
    }

    static void Main()
    {
        string[] input_number = Console.ReadLine().Split();

        long a = long.Parse(input_number[0]);
        long b = long.Parse(input_number[1]);

        long sum = a + b;

        long aClean = RemoveZero(a);
        long bClean = RemoveZero(b);
        long sumClean = RemoveZero(sum);

        if (aClean + bClean == sumClean)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

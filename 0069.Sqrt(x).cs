public class Solution
{
    public int MySqrt(int x)
    {
        if (x <= 1) return x;
        int t = 2;
        while (true)
        {
            if (t * t == x)
            {
                return t;
            }

            if (t * t > x)
            {
                return t - 1;
            }
            if (t * t < 0)
            {
                return t - 1;
            }

            t++;
        }
    }

    public static void Main()
    {
        var s = new Solution();
        var r = s.MySqrt(2147483647);
        Console.WriteLine(r);
    }
}

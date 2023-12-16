public class Solution
{
    public int ClimbStairs(int n)
    {
        List<int> fib = new List<int>();
        fib.Add(1);
        fib.Add(1);
        for (int i = 2; i <= n; i++)
        {
            fib.Add(fib[i - 2] + fib[i - 1]);
        }
        return fib[n];
    }

    public static void Main()
    {
        var s = new Solution();
        var argument = 3;
        var r = s.ClimbStairs(argument);
        Console.WriteLine(r);
    }
}

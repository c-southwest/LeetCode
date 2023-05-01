public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> sums = new HashSet<int>();

        while (true)
        {
            n = GetSum(n);
            if (sums.Contains(n)) return false;
            if (n == 1) return true;
            sums.Add(n);
        }
        
        int GetSum(int num)
        {
            int r = 0;
            while (num != 0)
            {
                r += (num % 10) * (num % 10);
                num /= 10;
            }
            return r;
        }
    }
}
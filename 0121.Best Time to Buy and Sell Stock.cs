public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 1) return 0;
        int max = 0;
        int buy = 0;
        int sell = 1;
        while (sell < prices.Length)
        {
            if (prices[buy] >= prices[sell])
            {
                buy = sell++;
                continue;
            }

            int profit = prices[sell] - prices[buy];

            if (max < profit)
            {
                max = profit;
            }

            sell++;
        }

        return max;
    }

    public static void Main()
    {
        var s = new Solution();
        int r = s.MaxProfit([2, 1, 4, 5, 2, 9, 7]);
        Console.WriteLine(r);
    }
}

public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
        int start = 0, end = n - 1, count = 1;
        while (count < n * n)
        {
            for (int i = start; i < end; i++) result[start][i] = count++;
            for (int i = start; i < end; i++) result[i][end] = count++;
            for (int i = end; i > start; i--) result[end][i] = count++;
            for (int i = end; i > start; i--) result[i][start] = count++;
            start++;
            end--;
        }
        if(n%2==1) { result[n/2][n / 2]=n*n; }
        return result;
    }
}

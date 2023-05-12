public class Solution
{
    public string ReverseStr(string s, int k)
    {
        char[] c = s.ToCharArray();
        int start = 0;
        //int end = k;
        //while (end <= s.Length)
        //{
        //    Reverse(start, end - 1);
        //    start += 2 * k;
        //    end = start + k;
        //}
        //if (start < s.Length - 1)
        //{
        //    Reverse(start, s.Length - 1);
        //}

        for (int i = start; i <= s.Length; i+=2*k)
        {
            if(i+k < s.Length)
            {
                Reverse(i, i+k-1);
            }
            else
            {
                Reverse(i, s.Length-1);
            }
        }

        void Reverse(int a, int b)
        {
            while (a < b)
            {
                (c[a], c[b]) = (c[b], c[a]);
                a++;
                b--;
            }
        }
        return new string(c);
    }
}

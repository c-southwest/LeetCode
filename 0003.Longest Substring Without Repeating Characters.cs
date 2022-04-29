

var s = "abba";
var solution = new Solution();
var r = solution.LengthOfLongestSubstring(s);
System.Console.WriteLine(r);

public class Solution
{
    public int LengthOfLongestSubstring_origin(string s)
    {
        var dict = new Dictionary<char, int>();
        var longest = 0;
        var count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                if (longest < count) longest = count;
                count = 0;
                i = dict[s[i]];
                dict.Clear();
            }
            else
            {
                dict[s[i]] = i;
                count++;
            }
        }
        return longest < count ? count : longest;
    }

    public int LengthOfLongestSubstring(string s)
    {
        var dict = new Dictionary<char, int>();
        int longest = 0, start = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                if (longest < i - start) longest = i - start;
                if (dict[s[i]] + 1 > start) start = dict[s[i]] + 1;
                dict[s[i]] = i;
            }
            else
            {
                dict[s[i]] = i;
            }
        }
        return longest < s.Length - start ? s.Length - start : longest;
    }
}
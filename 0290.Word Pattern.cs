public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        var words = s.Split(' ');
        int[] a1 = new int[128];
        Dictionary<string, int> d2 = new Dictionary<string, int>();
        if (pattern.Length != words.Length)
        {
            return false;
        }
        for (int i = 0; i < pattern.Length; i++)
        {
            if (d2.ContainsKey(words[i]) == false)
            {
                d2.Add(words[i],0);
            }
            if (a1[pattern[i]] == d2[words[i]])
            {
                a1[pattern[i]] = i + 1;
                d2[words[i]] = i + 1;
            }
            else
            {
                return false;
            }
        }
        return true;
    }

    public static void Main()
    {
        var s = new Solution();
        string argument = "abba";
        var r = s.WordPattern(argument, "dog cat cat dog");
        Console.WriteLine(r);
    }
}

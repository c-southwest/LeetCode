public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        int index1 = 0, index2 = 0;
        while (index1 < s.Length && index2 < t.Length)
        {
            if (s[index1] == t[index2])
            {
                index1++;
                index2++;
            }
            else
            {
                index2++;
            }
        }

        if (index1 == s.Length)
        {
            return true;
        }

        return false;
    }

    public static void Main()
    {
        var s = new Solution();
        string argument = "abc";
        var r = s.IsSubsequence(argument, "ahbgdc");
        Console.WriteLine(r);
    }
}

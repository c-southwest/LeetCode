public class Solution
{
    public bool IsAnagram_original(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] a1 = new int[26];
        int[] a2 = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            a1[s[i] - 'a']++;
            a2[t[i] - 'a']++;
        }

        for (int i = 0; i < a1.Length; i++)
        {
            if (a1[i] != a2[i])
            {
                return false;
            }
        }

        return true;
    }
    
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] a = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            a[s[i] - 'a']++;
            a[t[i] - 'a']--;
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        var s = new Solution();
        string argument = "anagram";
        var r = s.IsAnagram(argument, "nagaram");
        Console.WriteLine(r);
    }
}

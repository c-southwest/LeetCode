public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> dic1 = new Dictionary<char, int>();
        Dictionary<char, int> dic2 = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (dic1.ContainsKey(c))
                dic1[c] += 1;
            else
                dic1[c] = 0;
        }
        foreach (char c in t)
        {
            if (dic2.ContainsKey(c))
                dic2[c] += 1;
            else
                dic2[c] = 0;
        }
        if (dic1.Count != dic2.Count)
            return false;
        foreach (var item in dic1)
        {
            if (!dic2.Contains(item)) return false;
        }
        return true;
    }
}

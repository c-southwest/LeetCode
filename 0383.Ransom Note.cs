public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> table = new Dictionary<char, int>();
        foreach (char c in magazine)
        {
            if (table.ContainsKey(c))
            {
                table[c]++;
            }
            else
            {
                table[c] = 1;
            }
        }
        foreach (char c in ransomNote) {
            if (table.ContainsKey(c))
            {
                table[c]--;
            }
            else
            {
                return false;
            }
        }
        foreach(var item in table.Values)
        {
            if (item < 0)
            {
                return false;
            }
        }
        return true;
    }
}
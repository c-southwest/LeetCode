public class Solution
{
    public bool IsPalindrome(string s)
    {
        int p1 = 0;
        int p2 = s.Length - 1;
        bool r = true;
        while (p1 <= p2)
        {
            char c1, c2;
            if (s[p1] >= 'a' && s[p1] <= 'z')
            {
                c1 = s[p1];
            }
            else if (s[p1] >= 'A' && s[p1] <= 'Z')
            {
                c1 = (char)('a'+s[p1]-'A');
            }
            else if (s[p1] >= '0' && s[p1] <= '9')
            {
                c1 = s[p1];
            }
            else
            {
                p1++;
                continue;
            }

            if (s[p2] >= 'a' && s[p2] <= 'z')
            {
                c2 = s[p2];
            }
            else if (s[p2] >= 'A' && s[p2] <= 'Z')
            {
                c2 = (char)('a'+s[p2]-'A');
            }
            else if (s[p2] >= '0' && s[p2] <= '9')
            {
                c2 = s[p2];
            }
            else
            {
                p2--;
                continue;
            }

            if (c1 != c2)
            {
                r = false;
                break;
            }

            p1++;
            p2--;
        }

        return r;
    }

    public static void Main()
    {
        var s = new Solution();
        var r = s.IsPalindrome("A man, a plan, a canal: Panama");
        Console.WriteLine(r);
    }
}

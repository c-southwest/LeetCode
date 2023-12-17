public class Solution
{
    public bool IsIsomorphic2(string s, string t)
    {
        Dictionary<char, char> dictionary = new();
        Dictionary<char, char> beMappedDict = new();
        int i = 0;
        while (i < s.Length)
        {
            if (dictionary.ContainsKey(s[i]))
            {
                if (dictionary[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (s[i] == t[i])
                {
                    dictionary.Add(s[i], t[i]);
                    if (beMappedDict.ContainsKey(t[i]) == false)
                    {
                        beMappedDict.Add(t[i], s[i]);
                    }
                    else
                    {
                        if (beMappedDict[t[i]] != t[i])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (beMappedDict.ContainsKey(t[i]))
                    {
                        return false;
                    }

                    dictionary.Add(s[i], t[i]);
                    beMappedDict.Add(t[i], s[i]);
                }
            }

            i++;
        }

        return true;
    }

    public bool IsIsomorphic(string s, string t)
    {
        int[] a1 = new int[128];
        int[] a2 = new int[128];
        for (int i = 0; i < s.Length; i++)
        {
            if (a1[s[i]] == a2[t[i]])
            {
                a1[s[i]] = i + 1;
                a2[t[i]] = i + 1;
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
        string argument = "egg";
        var r = s.IsIsomorphic(argument, "add");
        Console.WriteLine(r);
    }
}

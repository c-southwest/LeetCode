    public string LongestCommonPrefix(string[] strs)
    {
        if (strs[0].Length == 0) return "";
        int index = 0;
        for (int i = 0; i < strs[0].Length; i++)
        {
            index = i;
            foreach (var s in strs[1..])
            {
                if (s.Length-1 >= index)
                {
                    if (strs[0][index] == s[index])
                    {
                        continue;
                    }
                    else
                    {
                        goto EXIT;  // not equal
                    }
                }
                else
                {
                    goto EXIT; // found a shorter string
                }
            }
        }

        index++;
        EXIT:
        return strs[0][..index]; // range is [a,b)
    }

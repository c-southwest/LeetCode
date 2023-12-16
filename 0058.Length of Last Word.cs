public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int pointer = s.Length - 1;
        bool start = false;
        int count = 0;
        while (pointer >= 0)
        {
            if (s[pointer] == ' ' && start)
            {
                break;
            }

            if (s[pointer] != ' ')
            {
                start = true;
                count++;
            }

            pointer--;
        }

        return count;
    }

    public static void Main()
    {
        var s = new Solution();
        string argument = "   fly me   to   the moon  ";
        var r = s.LengthOfLastWord(argument);
        Console.WriteLine(r);
    }
}

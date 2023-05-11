public class Solution
{
    /// <summary>
    /// Hash table method
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum_Hash(int[] numbers, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (dict.ContainsKey(numbers[i]))
            {
                return new int[] { dict[numbers[i]], i + 1 };
            }
            if (dict.ContainsKey(target - numbers[i]))
                continue;
            dict.Add(target - numbers[i], i + 1);
        }
        return null;
    }

    /// <summary>
    /// Two pointers
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public int[] TwoSum(int[] numbers, int target)
    {
        if (numbers.Length <= 1) return null;
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else if (numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else
            {
                return new int[] { left + 1, right + 1 };
            }
        }
        return null;
    }
}

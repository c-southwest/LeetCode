public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count =0;
        foreach (var item in nums)
        {
            if(count==0){
                candidate = item;
                count++;
            }else{
                if(candidate == item) {
                    count++;
                }else{
                    count--;
                }
            }
        }
        return candidate;
    }
}
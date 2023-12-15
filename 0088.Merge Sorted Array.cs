public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int pointer1 = m - 1;
        int pointer2 = n - 1;
        int pointer = m + n - 1;
        while(pointer1 != pointer){
            if(pointer1 <0){
                nums1[pointer] = nums2[pointer2];
                pointer2--;
                pointer--;
                continue;
            }
            if(nums1[pointer1]<nums2[pointer2]){
                nums1[pointer] = nums2[pointer2];
                pointer2--;
                pointer--;
            }else{
                nums1[pointer] = nums1[pointer1];
                pointer1--;
                pointer--;
            }

        }
        
    }
}
import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import java.util.Stack;

class Solution {
    // public int maxSubArray(int[] nums) {
    //     int max=nums[0];
    //     for(int i=1; i<nums.length; i++){
    //         if(nums[i-1] > 0 ){
    //             nums[i] = nums[i-1]+nums[i];
    //         }
    //         max = max>nums[i]?max:nums[i];  //update max
    //     }
    //     return max;
    // }
    public int maxSubArray(int[] nums) {
        int max=nums[0];
        int pre = 0;
        for(int i=0; i<nums.length; i++){
            pre = Math.max(pre + nums[i], nums[i]);
            max = max>pre?max:pre;  //update max
        }
        return max;
    }

}

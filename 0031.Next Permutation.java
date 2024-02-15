import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import java.util.Stack;

class Solution {
    public void nextPermutation(int[] nums) {
        int indexOfSmall = -1;
        for (int i = nums.length-1; i >= 1; i--) {
            if (nums[i]>nums[i-1]) {
                indexOfSmall = i-1;
                break;
            }
        }
        if(indexOfSmall == -1){
            reverse(nums, 0, nums.length-1);
            return;
        }

        for(int i=nums.length-1; i>indexOfSmall; i--){
            if (nums[i]>nums[indexOfSmall]) {
                int tmp = nums[i];
                nums[i] = nums[indexOfSmall];
                nums[indexOfSmall] = tmp;
                reverse(nums, indexOfSmall+1, nums.length-1);
                break;
            }
        }
    }

    void reverse(int[] nums, int start, int end){
        while(start < end){
            int tmp = nums[end];
            nums[end] = nums[start];
            nums[start] = tmp;
            end--;
            start++;
        }
    }
}

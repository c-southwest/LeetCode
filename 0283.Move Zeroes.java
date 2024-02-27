class Solution {
    public void moveZeroes(int[] nums) {
        int j = 0;
        for (int i = 0; i < nums.length; i++) {
            if(nums[i] != 0){
                if(nums[i] == nums[j]){

                }else{
                    nums[j] = nums[i];
                }
                j++;
            }
        }
        for (int i = j; i < nums.length; i++) {
            nums[i]=0;
        }
    }
}

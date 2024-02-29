class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
        Arrays.sort(nums);
        int n = nums.length;
        List<List<Integer>> ans = new ArrayList<>();
        for (int i = 0; i < nums.length; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) {
                continue;
            }
            int k = n - 1;
            int target = -nums[i];
            // iterate second
            for (int j = i + 1; j < n; j++) {
                if(j>i+1 && nums[j] == nums[j-1]){
                    continue;
                }
                while(j < k && nums[j] + nums[k] > target){
                    k--;
                }
                if(j == k){
                    break;
                }
                if(nums[j] + nums[k] == target){
                    ans.add(Arrays.asList(nums[i],nums[j],nums[k]));
                }
            }
        }
        return ans;
    }
}

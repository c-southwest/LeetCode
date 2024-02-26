class Solution {
    public int longestConsecutive(int[] nums) {
        Set<Integer> set = new HashSet<>();
        for (int num : nums) {
            set.add(num);
        }
        int longest = 0;
        for (Integer i : set) {
            if(set.contains(i-1)) continue;
            int l = 1;
            while(true){
                if(set.contains(i+l)){
                    l++;
                }else{
                    break;
                }
            }
            longest = Math.max(longest, l);
        }
        return longest;
    }
}

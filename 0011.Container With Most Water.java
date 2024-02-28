class Solution {
    public int maxArea(int[] height) {
        int max = 0;
        int start = 0;
        int end = height.length - 1 ;
        while(start < end){
            max = Math.max(max, Math.min(height[end], height[start]) * (end-start));
            if(height[start] > height[end]){
                end--;
            }else{
                start++;
            }
        }
        return max;
    }
}

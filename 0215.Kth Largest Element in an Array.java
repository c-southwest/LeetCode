class Solution {
    public int findKthLargest(int[] nums, int k) {
        PriorityQueue<Integer> pq = new PriorityQueue<>(k);
        for (int num : nums) {
            if (pq.size() < k) {
                pq.offer(num);
            }else if(pq.peek() < num){
                pq.poll();
                pq.offer(num);
            }
        }
        return pq.poll();
    }
}

import java.util.*;

public class Main {
    public static void main(String[] args) {
        new Solution().findKthLargest(new int[]{3, 2, 1, 5, 6, 4}, 2);
    }
}

class Solution {
    public int[] topKFrequent2(int[] nums, int k) {

        HashMap<Integer, Integer> map = new HashMap<>();
        for (int num : nums) {
            map.put(num, map.getOrDefault(num, 0) + 1);
        }

        PriorityQueue<Map.Entry<Integer, Integer>> pq = new PriorityQueue<>(new Comparator<>() {
            @Override
            public int compare(Map.Entry<Integer, Integer> o1, Map.Entry<Integer, Integer> o2) {
                return o2.getValue() - o1.getValue();
            }
        });

        pq.addAll(map.entrySet());
        List<Integer> res = new ArrayList<>(k);
        for (int i = 0; i < k; i++) {
            res.add(pq.poll().getKey());
        }
        return res.stream().mapToInt(a -> a).toArray();
    }

    public int[] topKFrequent(int[] nums, int k) {

        HashMap<Integer, Integer> map = new HashMap<>();
        for (int num : nums) {
            map.put(num, map.getOrDefault(num, 0) + 1);
        }

        PriorityQueue<Map.Entry<Integer, Integer>> pq = new PriorityQueue<>(new Comparator<>() {
            @Override
            public int compare(Map.Entry<Integer, Integer> o1, Map.Entry<Integer, Integer> o2) {
                return o1.getValue() - o2.getValue();
            }
        });

        for(Map.Entry<Integer, Integer> entry : map.entrySet()){
            if(pq.size() < k){
                pq.offer(entry);
            }else if(pq.peek().getValue() < entry.getValue()){
                pq.poll();
                pq.offer(entry);
            }
        }

        int[] res = new int[k]  ;
        for (int i = 0; i < k; i++) {
            res[i] = pq.poll().getKey();
        }
        return res;
    }
}

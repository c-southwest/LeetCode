package local.west.oop.leetcode;

import java.util.*;

public class Test {
    public static void main(String[] args) {

    }
}

class Solution {
    public long kthLargestLevelSum2(TreeNode root, int k) {
        List<TreeNode> record = new LinkedList<>();
        if(root == null){
            return -1;
        }
        record.add(root);
        PriorityQueue<Long> minHeap = new PriorityQueue<>(k);
        while(!record.isEmpty()){
            long levelSum = 0;
            int levelSize = record.size();
            for (int i = 0; i < levelSize; i++) {
                TreeNode n = record.removeFirst();
                levelSum += n.val;
                if(n.left != null) record.add(n.left);
                if(n.right != null) record.add(n.right);
            }
            if(minHeap.size()<k){
                minHeap.add(levelSum);
            }else{
                if(levelSum > minHeap.peek()){
                    minHeap.poll();
                    minHeap.add(levelSum);
                }
            }
        }
        if(minHeap.size() < k) return -1;
        return minHeap.isEmpty() ? -1 : minHeap.peek();
    }

    public long kthLargestLevelSum(TreeNode root, int k) {
        List<TreeNode> record = new LinkedList<>();
        if(root == null){
            return -1;
        }
        record.add(root);
        List<Long> ans = new ArrayList<>();
        while(!record.isEmpty()){
            long levelSum = 0;
            int levelSize = record.size();
            for (int i = 0; i < levelSize; i++) {
                TreeNode n = record.removeFirst();
                levelSum += n.val;
                if(n.left != null) record.add(n.left);
                if(n.right != null) record.add(n.right);
            }
            ans.add(levelSum);
        }
        if(k>ans.size()) return -1;
        ans.sort(Comparator.reverseOrder());
        return ans.get(k-1);
    }
}

class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;

    TreeNode() {
    }

    TreeNode(int val) {
        this.val = val;
    }

    TreeNode(int val, TreeNode left, TreeNode right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

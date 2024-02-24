package local.west.oop.leetcode;

import java.util.*;

public class Test {
    public static void main(String[] args) {


/*        // 构造树的节点
        TreeNode root = new TreeNode(5);
        root.left = new TreeNode(3);
        root.right = new TreeNode(7);
        root.left.left = new TreeNode(2);
        root.left.right = new TreeNode(4);
        root.right.right = new TreeNode(8);

        // 测试中序遍历
        Solution solution = new Solution();
        List<Integer> list = solution.getInorder(root);
        System.out.println(list);

        System.out.println(Collections.binarySearch(list, 8));
        System.out.println(Collections.binarySearch(list, 9));

        // 示例：使用closestNodes方法，假设有查询
        List<Integer> queries = Arrays.asList(2, 5, 7); // 可以根据需要调整查询
        List<List<Integer>> result = solution.closestNodes(root, queries);
        System.out.println(result);*/
        String[] originalArray = {"a", "b", "c"};
        List<String> asList = Arrays.asList(originalArray);
        //List<String> asList = List.of(originalArray);
        System.out.println("Original list: " + asList);

// 修改原始数组
        originalArray[1] = "d";
        asList.set(1,"2");

// 再次打印 asList 来查看其是否被修改
        System.out.println("Modified list after array change: " + asList);

    }
}

class Solution {
    public List<List<Integer>> closestNodes(TreeNode root, List<Integer> queries) {
        List<Integer> list = new ArrayList<>();
        getInorder(root, list);
        List<List<Integer>> ans = new ArrayList<>();
        System.out.println(list);
        for (Integer query : queries) {
            int r = Collections.binarySearch(list, query);
            if (r >= 0) {
                int v = list.get(r);
                ans.add(List.of(v, v));
                continue;
            }
            int left = -1;
            int right = -1;
            int desireIndex = (-r) - 1;
            if (desireIndex >= 1) {
                left = list.get(desireIndex - 1);
            }
            if(desireIndex < list.size()){
                right = list.get(desireIndex);
            }
            ans.add(List.of(left, right));
        }
        return ans;
    }

    void getInorder(TreeNode root, List<Integer> result) {
        if (root == null) {
            return;
        }
        getInorder(root.left, result)   ;
        result.add(root.val);
        getInorder(root.right, result);
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

package local.west.oop.leetcode;

import java.util.*;

public class Test {
    public static void main(String[] args) {

    }
}

class Solution {
    public boolean isSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;
        boolean isLeftSame = true;
        boolean isRightSame = true;
        isLeftSame = isSameTree(p.left, q.left);
        isRightSame = isSameTree(p.right, q.right);
        return isLeftSame && isRightSame;
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

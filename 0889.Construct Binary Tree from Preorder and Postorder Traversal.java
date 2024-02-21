package local.west.oop.leetcode;

public class Test {
    public static void main(String[] args) {
        int[] pre = {1,2,4,5,3,6,7};
        int[] post = {4,5,2,6,7,3,1};
        Solution.constructFromPrePost(pre,post);
    }
}

class Solution {
    static public TreeNode constructFromPrePost(int[] preorder, int[] postorder) {
        int end = preorder.length - 1;
        var r = dfs(preorder, postorder, 0, end, 0, end);
        return r;
    }

    static TreeNode dfs(int[] preorder, int[] postorder, int preStart, int preEnd, int postStart, int postEnd){
        if(preStart > preEnd){
            return null;
        }
        if(preStart == preEnd){
            return new TreeNode(preorder[preStart], null, null);
        }
        int root = preorder[preStart];

        int pivot = 0;
        int leftSize = 0;
        for (int i = postStart; i <= postEnd; i++) {
            if (postorder[i]==preorder[preStart+1]){
                pivot = i;
                leftSize = pivot-postStart+1;
            }
        }
        TreeNode leftT = dfs(preorder, postorder, preStart+1, preStart+leftSize, postStart, postStart+leftSize-1);
        TreeNode rightT = dfs(preorder, postorder, preStart+1+leftSize, preEnd, postStart+leftSize, postEnd-1);
        return new TreeNode(root, leftT, rightT);
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

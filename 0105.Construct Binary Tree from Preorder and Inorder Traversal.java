class Solution {
    Map<Integer, Integer> indexMap;
    public TreeNode buildTree(int[] preorder, int[] inorder) {
        int n = preorder.length;
        indexMap = new HashMap<Integer, Integer>();
        for (int i = 0; i < n; i++) {
            indexMap.put(inorder[i], i);
        }
        return dfs(preorder, inorder, 0, n-1,0,n-1);
    }

    public TreeNode dfs(int[] preorder, int[] inorder, int preLeft, int preRight, int inLeft, int inRight){
        if(preLeft > preRight){
            return null;
        }
        int preRoot = preLeft;
        int inRoot = indexMap.get(preorder[preRoot]);
        TreeNode root = new TreeNode(preorder[preRoot]);
        int sizeLeftTree = inRoot - inLeft;
        root.left = dfs(preorder, inorder, preLeft+1,preLeft+sizeLeftTree, inLeft, inRoot-1);
        root.right = dfs(preorder, inorder, preLeft+sizeLeftTree+1, preRight, inRoot+1, inRight);
        return root;
    }
}

class Solution {
    public List<List<Integer>> zigzagLevelOrder(TreeNode root) {
        List<List<Integer>> ans = new ArrayList<List<Integer>>();
        LinkedList<TreeNode> record = new LinkedList<TreeNode>();
        Boolean right = true;
        if(root == null){
            return ans;
        }
        record.add(root);
        while (!record.isEmpty()) {
            List<Integer> level = new ArrayList<>();
            int size = record.size();
            if(right){
                for (int i = 0; i < size; i++) {
                    TreeNode node = record.remove();
                    level.add(node.val);
                    if(node.left != null) record.add(node.left);
                    if(node.right != null) record.add(node.right);
                }
            }else{
                for (int i = size-1; i >=0 ; i--) {
                    TreeNode node = record.remove(i);
                    level.add(node.val);
                    if(node.right != null) record.add(i, node.right);
                    if(node.left != null) record.add(i,node.left);
                }
            }
            right = !right;
            ans.add(level);
        }
        return ans;
    }
}

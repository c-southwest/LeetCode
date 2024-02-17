/*
// Definition for a Node.
class Node {
    public int val;
    public List<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, List<Node> _children) {
        val = _val;
        children = _children;
    }
};
*/

    class Solution {
        public List<List<Integer>> levelOrder(Node root) {
            Queue<List<Node>> record = new LinkedList<>();
            List<List<Integer>> ans = new ArrayList<>();
            if(root == null){
                return ans;
            }
            List<Node> t = new ArrayList<>();
            t.add(root);
            record.add(t);
            while(!record.isEmpty()){
                List<Integer> level = new ArrayList<>();
                int size = record.size();
                for (int i=0; i<size; i++){
                    List<Node> children = record.remove();
                    for(Node node: children){
                        level.add(node.val);
                        if(!node.children.isEmpty()){
                            record.add(node.children);
                        }
                    }
                }
                ans.add(level);
            }
            return ans;
        }
    }

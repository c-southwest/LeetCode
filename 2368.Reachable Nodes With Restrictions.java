class Solution {
    int count = 0;

    public int reachableNodes(int n, int[][] edges, int[] restricted) {
        boolean[] isRestricted = new boolean[n];
        for (int i : restricted) {
            isRestricted[i] = true;
        }
        List<Integer>[] g = new List[n];
        for (int i = 0; i < n; i++) {
            g[i] = new ArrayList<>();
        }
        for(int[] v : edges){
            g[v[0]].add(v[1]);
            g[v[1]].add(v[0]);
        }
        dfs(0, -1, isRestricted, g);
        return count;
    }
    
    public void dfs(int x, int f, boolean[] isRestricted, List<Integer>[] g){
        count++;
        for (Integer y : g[x]) {
            if(y != f && !isRestricted[y]){
                dfs(y, x, isRestricted, g);
            }
        }
    }
}

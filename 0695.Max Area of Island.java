class Solution {
    int rows;
    int cols;
    public int maxAreaOfIsland(int[][] grid) {
        rows = grid.length;
        cols = grid[0].length;
        int result = 0 ;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result = Math.max(result, dfs(grid,i,j));
            }
        }
        return result;
    }

    int dfs(int[][] grid, int i, int j){
        if((i<0 || i>=rows) || (j<0 || j>=cols)){
            return 0;
        }
        if(grid[i][j]==1){
            grid[i][j]=0;
            return 1 + dfs(grid, i-1,j) + dfs(grid, i+1,j) + dfs(grid, i,j-1) + dfs(grid, i,j+1);
        }else{
            return 0;
        }
    }
}

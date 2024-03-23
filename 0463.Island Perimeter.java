class Solution {
    int rows;
    int cols;
    public int islandPerimeter(int[][] grid) {
        rows = grid.length;
        cols = grid[0].length;
        int result = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    return dfs(grid, i, j);
                }
            }
        }
        return result;
    }
    int dfs(int[][] grid, int i, int j) {
        if ((i < 0 || i >= rows) || (j < 0 || j >= cols)) {
            return 1;
        } else {
            // 找到陆地
            if(grid[i][j] == 0) return 1;
            if(grid[i][j] == 2) return 0;
            grid[i][j] = 2;
            return dfs(grid, i, j-1) + dfs(grid, i, j+1) + dfs(grid, i-1, j)+ dfs(grid, i+1, j);
        }
    }
}

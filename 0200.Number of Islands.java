class Solution {
    int rows;
    int cols;
    public int numIslands(char[][] grid) {
        rows = grid.length;
        cols = grid[0].length;
        int result = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == '1') {
                    result++;
                    dfsClear(grid, i, j);
                }
            }
        }
        return result;
    }
    void dfsClear(char[][] grid, int i, int j) {
        if ((i < 0 || i >= rows) || (j < 0 || j >= cols)) {
        } else {
            grid[i][j] = '0';
            if (j - 1 >= 0 && grid[i][j - 1] == '1') dfsClear(grid, i, j - 1);
            if (j + 1 < cols && grid[i][j + 1] == '1') dfsClear(grid, i, j + 1);
            if (i - 1 >= 0 && grid[i - 1][j] == '1') dfsClear(grid, i - 1, j);
            if (i + 1 < rows &&grid[i + 1][j] == '1')dfsClear(grid, i + 1, j);
        }
    }
}

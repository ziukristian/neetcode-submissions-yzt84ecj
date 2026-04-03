public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {

        var max = 0;

        var rows = grid.Length;
        var cols = grid[0].Length;

        var visited = new bool[rows,cols];

        int traverse(int x, int y){
            if(x<0 || x>=rows || y<0 || y>=cols) return 0;
            if(visited[x,y] || grid[x][y] == 0) return 0;

            visited[x,y] = true;

            return 1+traverse(x-1,y)+traverse(x+1,y)+traverse(x,y-1)+traverse(x,y+1);
        }

        for(var i=0;i<rows;i++){
            for(var j=0;j<cols;j++){
                if(grid[i][j] == 1 && !visited[i,j]){
                    max = Math.Max(traverse(i,j),max);
                }
            }
        }


        return max;
        
    }
}

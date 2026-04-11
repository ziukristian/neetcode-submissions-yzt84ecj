public class Solution {
    public int NumIslands(char[][] grid) {

        var sol = 0;
        var rows = grid.Length;
        var cols = grid[0].Length;


        void traverse(int x, int y){
            if(x >= rows || x<0 || y >= cols || y<0 || grid[x][y] == '0' ) return;

            grid[x][y] = '0';

            traverse(x+1,y);
            traverse(x-1,y);
            traverse(x,y+1);
            traverse(x,y-1);
        }
        
        for(var i = 0; i< rows;i++){
            for(var j = 0; j< cols;j++){
                if(grid[i][j] == '1'){
                    sol++;
                    traverse(i,j);
                }
            }
        }

        return sol;
        

    }
}

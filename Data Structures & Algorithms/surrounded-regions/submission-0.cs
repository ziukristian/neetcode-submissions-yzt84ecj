public class Solution {
    public void Solve(char[][] board) {
        
        var rows = board.Length;
        var cols = board[0].Length;

        for(var i=0;i<cols;i++){
            bfs(0,i);
            bfs(rows-1,i);
        }

        for(var i=0;i<rows;i++){
            bfs(i,0);
            bfs(i,cols-1);
        }

        for(var i=0;i<rows;i++){
            for(var j=0;j<cols;j++){
                if(board[i][j] == 't'){
                    board[i][j] = 'O';
                } else if(board[i][j] == 'O'){
                    board[i][j] = 'X';
                }
            }
        }

        void bfs(int x, int y){
            if(x<0 || x>=rows || y<0 || y>=cols || board[x][y] != 'O') return;

            board[x][y] = 't';

            bfs(x-1,y);
            bfs(x+1,y);
            bfs(x,y-1);
            bfs(x,y+1);
        }
    }
}

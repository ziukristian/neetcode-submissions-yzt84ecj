public class Solution {
    public bool Exist(char[][] board, string word) {

        var found = false;

        bool backtrack(int current, int x, int y, char[,] visited){
            if(current == word.Length) return true;
            if(x<0 || x>=board.Length || y<0 || y>=board[0].Length || word[current] != board[x][y] || visited[x,y] == '#') return false;

            visited[x,y] = '#';
            var found = 
            backtrack(current + 1, x+1, y, visited) ||
            backtrack(current + 1, x-1, y, visited) ||
            backtrack(current + 1, x, y+1, visited) ||
            backtrack(current + 1, x, y-1, visited);

            visited[x,y] = board[x][y];

            return found;

        }

        for(var i=0;i<board.Length;i++){
            for(var j=0;j<board[0].Length;j++){
                found = backtrack(0,i,j, new char[board.Length,board[0].Length]);
                if(found) return true;
            }
        }

        return found;
        
    }
}

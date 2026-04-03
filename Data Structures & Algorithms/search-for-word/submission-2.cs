public class Solution {
    public bool Exist(char[][] board, string word) {

        var width = board.Length;
        var height = board[0].Length;

        bool find(int x,int y, int index){

            if(index>word.Length-1) return true;

            

            if(x<0 || x>width-1 || y<0 || y>height-1 || board[x][y] != word[index]) return false;

            var c = board[x][y];
            board[x][y] = '#';

            var found = find(x+1,y,index+1) ||
            find(x-1,y,index+1) ||
            find(x,y+1,index+1) ||
            find(x,y-1,index+1);

            board[x][y] = c;

            return found;
        }

        for(var i=0;i<width;i++){
            for(var j=0;j<height;j++){
                if(find(i,j,0)) return true;
            }
        }

        return false;

        
    }
}

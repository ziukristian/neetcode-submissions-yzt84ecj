public class Solution {
    public bool IsValidSudoku(char[][] board) {

        for(var i=0;i<9;i++){
            var seenRow = new HashSet<char>();
            var seenCol = new HashSet<char>();

            for(var j=0;j<9;j++){

                // ROW
                if(board[i][j] != '.'){
                    if(seenRow.Contains(board[i][j])){
                        return false;
                    } 

                    seenRow.Add(board[i][j]);
                }

                // COL
                if(board[j][i] != '.'){
                    if(seenCol.Contains(board[j][i])){
                        return false;
                    } 

                    seenCol.Add(board[j][i]);
                }

            }
        }

        for(var row=0;row<3;row++){
            for(var col=0;col<3;col++){
                var seen = new HashSet<char>();

                for(var i=0;i<3;i++){
                    for(var j=0;j<3;j++){
                        var c = board[row*3 + i][col*3 + j];
                        if(c != '.'){
                            if(seen.Contains(c)){
                                return false;
                            }  

                            seen.Add(c);  
                        }
                    }
                }
            }
        }

        return true;
        
    }
}

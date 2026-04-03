public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {

        var sol = new List<int>();

        var rows = matrix.Length;
        var cols = matrix[0].Length;

        var left = 0;
        var right = matrix[0].Length-1;
        var top = 0;
        var bottom = matrix.Length-1;


        while(sol.Count < rows * cols){

            for(var i=left;i<=right && sol.Count < rows * cols;i++){
                sol.Add(matrix[top][i]);
            }
            top++;

            for(var i=top;i<=bottom && sol.Count < rows * cols;i++){
                sol.Add(matrix[i][right]);
            }
            right--;

            for(var i=right;i>=left && sol.Count < rows * cols;i--){
                sol.Add(matrix[bottom][i]);
            }
            bottom--;

            for(var i=bottom;i>=top && sol.Count < rows * cols;i--){
                sol.Add(matrix[i][left]);
            }
            left++;

        }

        return sol;
        
    }
}

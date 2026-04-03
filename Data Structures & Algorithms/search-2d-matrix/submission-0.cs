public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        var m = matrix.Length;
        var n = matrix[0].Length;
        var left = 0;
        var right = m * n - 1;

        while(left <= right){
            int mid = left + (right - left)/2;

            int val = matrix[mid/n][mid%n];

            if(val == target) return true;

            if(val > target){
                right = mid-1;
            } else {
                left = mid + 1;
            }
        }

        return false;
    }
}

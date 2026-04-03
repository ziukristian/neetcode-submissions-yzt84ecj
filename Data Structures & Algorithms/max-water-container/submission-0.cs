public class Solution {
    public int MaxArea(int[] heights) {
        
        var left = 0;
        var right = heights.Count()-1;

        var res = 0;

        while(left<right){

            var water = Math.Min(heights[left],heights[right]) * (right-left);

            res = Math.Max(water, res);

            if(heights[left] > heights[right]){
                right--;
            } else left++;
        }

        return res;
    }
}

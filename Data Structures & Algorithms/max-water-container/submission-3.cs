public class Solution {
    public int MaxArea(int[] heights) {

        var left = 0;
        var right = heights.Length-1;

        var max = 0;


        while(left<right){
            var water = (right-left)*(Math.Min(heights[left],heights[right]));

            max = Math.Max(max,water);

            if(heights[left] > heights[right]){
                right--;
            } else left ++;

        }

        return max;
        
    }
}

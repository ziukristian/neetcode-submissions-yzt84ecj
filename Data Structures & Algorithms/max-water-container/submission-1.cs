public class Solution {
    public int MaxArea(int[] heights) {

        var max = 0;

        var left = 0;
        var right = heights.Length-1;


        while(left<right){

            var dist = right - left;

            if(heights[left]<heights[right]){
                max = Math.Max(max,heights[left]*dist);

                left++;
            } else {
                max = Math.Max(max,heights[right]*dist);

                right--;
            }

        }

        return max;
        
    }
}

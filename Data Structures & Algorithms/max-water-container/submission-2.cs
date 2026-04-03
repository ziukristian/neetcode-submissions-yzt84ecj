public class Solution {
    public int MaxArea(int[] heights) {

        int max = 0;

        var left = 0;
        var right = heights.Length-1;

        while(left < right){

            int delta = right-left;
            int height = Math.Min(heights[left],heights[right]);

            int area = delta*height;

            max = Math.Max(max,area);

            if(heights[left]<heights[right]){
                left++;
            } else right--;

        }



        return max;
        
    }
}

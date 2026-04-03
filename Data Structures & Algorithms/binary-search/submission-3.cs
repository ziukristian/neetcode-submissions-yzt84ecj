public class Solution {
    public int Search(int[] nums, int target) {


        var left = 0;
        var right = nums.Length-1;

        while(left<=right){

            var m = left + (right-left/2);

            var delta = target - nums[m];

            if(delta == 0) return m;

            if(delta > 0) left = m+1;

            if(delta < 0) right = m-1;
        }

        return -1;
        
    }
}

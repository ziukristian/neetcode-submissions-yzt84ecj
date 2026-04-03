public class Solution {
    public int MaxSubArray(int[] nums) {

        var max = nums[0];
        var currMax = nums[0];

        for(var i=1;i<nums.Length;i++){
            currMax = Math.Max(nums[i],currMax+nums[i]);

            max = Math.Max(currMax,max);
        }

        return max;
        
    }
}

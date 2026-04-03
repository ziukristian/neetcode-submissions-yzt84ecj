public class Solution {
    public int MaxSubArray(int[] nums) {

        var max = nums[0];

        int[] maxEndingAt = new int[nums.Length];
        maxEndingAt[0] = nums[0];

        for(var i = 1;i<nums.Length;i++){

            maxEndingAt[i] = Math.Max(nums[i],maxEndingAt[i-1]+nums[i]);

            max = Math.Max(maxEndingAt[i],max);
            
        }

        return max;
        
    }
}

public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0) return 0;

        var prev2 = 0;
        var prev1 = 0;

        for(var i=0;i<nums.Length;i++){

            var newMax = Math.Max(prev1,prev2+nums[i]);

            prev2 = prev1;
            prev1 = newMax;
        }

        return prev1;
        
    }
}

public class Solution {
    public int Rob(int[] nums) {

        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];

        var help = new int[nums.Length];

        help[0] = nums[0];
        help[1] = Math.Max(nums[1],nums[0]);

        for(var i=2;i<nums.Length;i++){
            help[i] = Math.Max(help[i-2] + nums[i],help[i-1]);
        }

        return Math.Max(help[nums.Length-1],help[nums.Length-2]);
    }
}

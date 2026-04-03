public class Solution {
    public bool CanJump(int[] nums) {
        
        var max = 0;

        for(var i =0;i<nums.Length;i++){
            if(max < i) return false;

            max = Math.Max(max,i+nums[i]);
        }

        return true;
    }
}

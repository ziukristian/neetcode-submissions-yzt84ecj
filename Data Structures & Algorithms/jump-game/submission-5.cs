public class Solution {
    public bool CanJump(int[] nums) {
        

        var longest = 0;

        for(var i=0;i<nums.Length;i++){

            if(longest < i) return false;

            longest = Math.Max(i+nums[i],longest);
        }

        return true;
    }
}

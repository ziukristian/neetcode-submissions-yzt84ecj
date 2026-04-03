public class Solution {
    public int Rob(int[] nums) {

        if(nums.Length==1) return nums[0];

        return Math.Max(RobLinear(nums,0,nums.Length-2),RobLinear(nums,1,nums.Length-1));
        
    }

    public int RobLinear(int[] nums, int start, int end){


        var prevMax = 0;
        var max = 0;

        for(var i = start;i<=end;i++){
            var temp = max;
            max = Math.Max(nums[i]+prevMax,max);
            prevMax = temp;
        }

        return max;
    }
}

public class Solution {
    public int LengthOfLIS(int[] nums) {

        var l = nums.Length;
        var dp = new int[l];

        var res = 1;

        for(var i=0;i<l;i++){
            var longest = 0;
            for(var j=0;j<i;j++){
                if(nums[j] < nums[i] && dp[j] > longest){
                    longest = dp[j];
                }
            }

            dp[i] = longest+1;

            res = Math.Max(longest+1,res);
        }

        return res;

        
    }
}

public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var ans = new int[nums.Count()];

        
        var zcounter = 0;
        foreach(var n in nums){
            if(n==0) {
                zcounter++;
            }
        }

        if(zcounter > 1) return ans;

        if(zcounter == 1) {
            var zindex = 0;
            var nonZeroProd = 1;
            for(var i = 0; i<nums.Count();i++){
                if(nums[i] == 0){
                    zindex = i;
                    continue;
                }

                nonZeroProd *= nums[i];
            
            }

            ans[zindex] = nonZeroProd;
            return ans;
        }

        ans[0] = 1;
        
        for(var i = 1; i<nums.Count();i++){
            ans[0] = ans[0] * nums[i];
        }

        for(var i = 1; i<nums.Count();i++){
            ans[i] = ans[i-1] / nums[i] * nums[i-1];
        }

        return ans;


    }
}

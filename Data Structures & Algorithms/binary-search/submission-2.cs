public class Solution {
    public int Search(int[] nums, int target) {
        

        var left = 0;
        var right = nums.Length -1 ;

        while(left <= right){
            int m = (right - left / 2) + left;

            if(nums[m] == target) return m;

            if(nums[m] > target){
                right = m-1;
            } else {
                left = m+1;
            }
        }

        return -1;
    }
}

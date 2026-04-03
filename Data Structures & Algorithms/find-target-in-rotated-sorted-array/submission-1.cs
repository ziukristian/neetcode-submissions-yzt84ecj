public class Solution {
    public int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length-1;

        while(left<=right){
            var m = left + (right-left)/2;

            if(nums[m] == target) return m;

            if(nums[left] <= nums[m]){
                if(target >= nums[left] && target < nums[m]){
                    right = m-1;
                } else left = m+1;
            } else {
                if(target <= nums[right] && target> nums[m]){
                    left = m+1;
                } else right = m-1;
            }
        }

        return -1;
    }
}

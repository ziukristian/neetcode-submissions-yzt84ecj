public class Solution {
    public int FindMin(int[] nums) {

        var left = 0;
        var right = nums.Length - 1;

        if(nums[right] > nums[left]) return nums[left];

        while(left<right){

            var m = left + (right-left)/2;

            if(nums[m] > nums[right]) 
                left = m+1;
            else 
                right = m;
        }

        return nums[left];
    }
}

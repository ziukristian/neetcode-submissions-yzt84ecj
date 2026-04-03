public class Solution {
    public int Search(int[] nums, int target) {


        var left = 0;
        var right = nums.Length-1;


        while(left<=right){
            var m = left + (right-left)/2;

            Console.WriteLine(m);

            if(nums[m]==target) return m;

            if(nums[left]<=nums[m]){
                // Left is ordered
                if(target>=nums[left] && target<nums[m]) right = m-1;
                else left = m+1;
            } else {
                //right is ordered
                if(target>=nums[m] && target<=nums[right]) left = m+1;
                else right = m-1;
            }
        }

        return -1;
        
    }
}

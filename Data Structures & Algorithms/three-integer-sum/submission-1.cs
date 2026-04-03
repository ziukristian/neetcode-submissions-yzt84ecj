public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var res = new List<List<int>>();

        Array.Sort(nums);

        for(var i = 0;i<nums.Count();i++){
            if(i>0 && nums[i]==nums[i-1]) continue;

            var left = i+1;
            var right = nums.Count()-1;

            while(left<right){

                if(left>i+1 && nums[left] == nums[left-1]) {
                    left++;
                    continue;
                }

                if(right<nums.Count()-1 && nums[right] == nums[right+1]){
                    right--;
                    continue;
                }

                var c = nums[i] + nums[left] + nums[right];

                if(c==0){
                    res.Add(new List<int>(){nums[i],nums[left],nums[right]});
                    right--;
                }

                if(c>0){
                    right--;
                }

                if(c<0){
                    left++;
                }
            }
        }

        return res;
    }
}

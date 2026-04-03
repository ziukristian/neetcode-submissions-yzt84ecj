public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();

        for(var i = 0; i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                return dict[nums[i]] > i ? new int[] {i,dict[nums[i]]} : new int[] {dict[nums[i]],i};
            }

            dict.Add(target-nums[i],i);
        }

        return new int[] {0,0};
    }
}

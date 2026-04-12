public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var complements = new Dictionary<int,int>();


        for(var i = 0;i<nums.Length;i++){

            var complement = target-nums[i];

            if(complements.TryGetValue(nums[i], out var idx)){
                return new int[]{idx,i};
            } else {
                complements.Add(complement,i);
            }
        }

        return new int[2];
    }
}

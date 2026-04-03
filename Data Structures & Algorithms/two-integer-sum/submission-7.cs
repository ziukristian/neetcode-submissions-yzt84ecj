public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dict = new Dictionary<int,int>();


        for(var i=0;i<nums.Length;i++){

            var compl = target - nums[i];

            if(dict.TryGetValue(compl, out int index)){
                return new int[]{index,i};
            }
            
            dict[nums[i]] = i;
        }

        return new int[]{};
    }
}

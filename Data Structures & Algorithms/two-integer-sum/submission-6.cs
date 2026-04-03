public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dict = new Dictionary<int,int>();


        for(var i=0;i<nums.Length;i++){

            var compl = target - nums[i];

            if(dict.ContainsKey(compl)){
                return i <  dict[compl] ? 
                    new int[]{i,dict[compl]} : 
                    new int[]{dict[compl],i};
            }
            
            dict[nums[i]] = i;
        }

        return new int[]{};
    }
}

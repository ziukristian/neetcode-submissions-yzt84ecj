public class Solution {
    public int SubarraySum(int[] nums, int k) {

        var sum = 0;
        var counter = 0;
        var dict = new Dictionary<int,int>();
        dict[0] = 1;

        foreach(var n in nums){
            sum += n;

            if(dict.ContainsKey(sum-k)){
                counter += dict[sum-k];
            } 

            dict[sum] = dict.GetValueOrDefault(sum) + 1;
        }
        
        return counter;
    }
}
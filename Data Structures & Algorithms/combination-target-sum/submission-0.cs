public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        
        var res = new List<List<int>>();

        void backtrack(List<int> current, int sum, int start){

            if(sum == target) {
                res.Add(new List<int>(current));
                return;
            }

            if(sum > target) return;

            for(var i = start; i<nums.Count();i++){
                current.Add(nums[i]);
                backtrack(current, sum + nums[i], i);
                current.RemoveAt(current.Count()-1);
            }
        }

        backtrack(new List<int>(), 0, 0);

        return res;
    }
}

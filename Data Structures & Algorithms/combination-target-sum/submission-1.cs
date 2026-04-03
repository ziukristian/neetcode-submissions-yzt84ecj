public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {

        var res = new List<List<int>>();
        
        void backtrack(List<int> current, int start, int sum){
            if(sum > target) return;
            if(sum == target) {
                res.Add(new List<int>(current));
                return;
            }

            for(var i=start;i<nums.Length;i++){
                current.Add(nums[i]);
                backtrack(current,i,sum+nums[i]);
                current.RemoveAt(current.Count-1);
            }
        }

        backtrack(new List<int>(),0,0);

        return res;


    }
}

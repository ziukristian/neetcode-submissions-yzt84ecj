public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {

        var sol =  new List<List<int>>();

        void backtrack(List<int> current,int index, int sum){
            if(sum > target) return;

            if(sum == target) {
                sol.Add(new List<int>(current));
            }

            for(var i=index;i<nums.Length;i++){
                current.Add(nums[i]);
                backtrack(current,i,sum+nums[i]);
                current.RemoveAt(current.Count-1);
            }
        }

        backtrack(new List<int>(),0,0);

        return sol;
        
    }
}

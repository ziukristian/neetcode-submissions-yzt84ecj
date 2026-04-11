public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {

        var sol = new List<List<int>>();

        Array.Sort(nums);

        void backtrack(List<int> current, int start, int sum){

            if(sum == target) {
                sol.Add(new List<int>(current));
                return;
            }

            if(sum > target) return;


            for(var i = start;i<nums.Length;i++){

                if (sum + nums[i] > target) break;

                current.Add(nums[i]);
                backtrack(current, i, sum+nums[i]);
                current.RemoveAt(current.Count-1);
            }

        }

        backtrack(new List<int>(),0,0);

        return sol;


        
    }
}

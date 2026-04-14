public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        var sol = new List<List<int>>();

        void backtrack(List<int> current, int start){

            sol.Add(new List<int>(current));

            for(var i=start;i<nums.Length;i++){
                current.Add(nums[i]);
                backtrack(current, i+1);
                current.RemoveAt(current.Count-1);
            }
        }

        backtrack(new List<int>(),0);

        return sol;
    }
}

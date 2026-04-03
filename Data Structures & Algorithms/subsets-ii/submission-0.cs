public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {

        var sol = new List<List<int>>();
        Array.Sort(nums);

        void backtrack(List<int> current, int start){
            sol.Add(new List<int>(current));

            for(var i = start; i<nums.Count();i++){
                if(i>start && nums[i] == nums[i-1]) continue;

                current.Add(nums[i]);
                backtrack(current, i+1);
                current.RemoveAt(current.Count()-1);
            }
        }

        backtrack(new List<int>(), 0 );

        return sol;
        
    }
}

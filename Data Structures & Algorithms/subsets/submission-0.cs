public class Solution {
    public List<List<int>> Subsets(int[] nums) {

        var res = new List<List<int>>();

        void backtrack(int start, List<int> current){

            res.Add(new List<int>(current));

            for(var i = start; i<nums.Count();i++){
                current.Add(nums[i]);
                backtrack(i+1, current);
                current.RemoveAt(current.Count()-1);
            }

        }

        backtrack(0, new List<int>());

        return res;
        
    }
}

public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        
        Array.Sort(candidates);
        var sol = new List<List<int>>();

        void backtrack(List<int> current, int start, int sum){

            if(sum == target) {
                sol.Add(new List<int>(current));
                return;
            }

            if(sum > target) return;

            for(var i=start;i<candidates.Count();i++){
                if (i > start && candidates[i] == candidates[i - 1])
                    continue;
                current.Add(candidates[i]);
                backtrack(current,i+1,sum+candidates[i]);
                current.RemoveAt(current.Count()-1);
            }
        }

        backtrack(new List<int>(),0,0);

        return sol;
    }
}

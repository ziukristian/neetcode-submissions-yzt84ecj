public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var sol = new List<List<int>>();

        var visitedNew = new int[nums.Count()];

        void backtrack(List<int> current, int[] visited){
            
            if(current.Count() == nums.Count()) {
                sol.Add(new List<int>(current));
                return;
            }
            
            for(var i = 0;i<nums.Count();i++){
                if(visited[i] == 1) continue;


                visited[i] = 1;
                current.Add(nums[i]);
                backtrack(current, visited);
                current.RemoveAt(current.Count() - 1);
                visited[i] = 0;
            }
        }

        backtrack(new List<int>(), visitedNew);

        return sol;
    }
}

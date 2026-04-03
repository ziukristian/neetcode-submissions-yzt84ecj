public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        var sol = new List<List<int>>();

        void backtrack(List<int> current, bool[] visited){
            if(current.Count() == nums.Length){
                sol.Add(new List<int>(current));
                return;
            }

            for(var i = 0; i<nums.Length;i++){

                if(visited[i]) continue;

                visited[i] = true;
                current.Add(nums[i]);

                backtrack(current,visited);

                visited[i] = false;
                current.RemoveAt(current.Count()-1);
            }
        }

        backtrack(new List<int>(), new bool[nums.Length]);

        return sol;
    }
}

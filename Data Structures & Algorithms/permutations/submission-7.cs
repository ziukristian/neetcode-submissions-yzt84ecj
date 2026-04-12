public class Solution {
    public List<List<int>> Permute(int[] nums) {
        
        var sol = new List<List<int>>();


        void backtrack(List<int> current, bool[] used){
            if(current.Count == nums.Length){
                sol.Add(new List<int>(current));
                return;
            }

            for(var i=0;i<nums.Length;i++){

                if(used[i]) continue;

                used[i] = true;
                current.Add(nums[i]);
                backtrack(current,used);
                current.RemoveAt(current.Count-1);
                used[i] = false;
            }
        }

        backtrack(new List<int>(),new bool[nums.Length]);

        return sol;
    }
}
public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);

        var sol = 0;

        foreach(var n in nums){
            if(set.Contains(n-1)) continue;
            var current = n;
            while(set.Contains(current)){
                sol = Math.Max(sol,current-n+1);
                current++;
            }
        }
        
        return sol;
    }
}

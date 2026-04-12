public class Solution {
    public int LongestConsecutive(int[] nums) {

        var set = new HashSet<int>(nums);
        int longest = 0;


        foreach(var n in nums){

            if(!set.Contains(n-1)){
                var current = n;
                var streak = 0;
                while(set.Contains(current)){
                    streak++;
                    current++;
                }

                longest = Math.Max(longest,streak);
            }
        }

        return longest;
        
    }
}

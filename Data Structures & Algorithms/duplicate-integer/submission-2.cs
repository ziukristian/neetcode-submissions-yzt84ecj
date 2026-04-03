public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        var map = new HashSet<int>();

        foreach(var n in nums){
            if(map.Contains(n)) return true;

            map.Add(n);
        }

        return false;
    }
}
public class Solution {
    public int LongestConsecutive(int[] nums) {
        var seq = new HashSet<int>(nums);

        var res = 0;

        foreach(var n in nums){
            if(!seq.Contains(n-1)){

                var counter = 0;
                var i = 0;
                while(seq.Contains(n+i)){
                    counter++;
                    i++;
                }

                res = Math.Max(counter,res);
            }
        }

        return res;
    }
}

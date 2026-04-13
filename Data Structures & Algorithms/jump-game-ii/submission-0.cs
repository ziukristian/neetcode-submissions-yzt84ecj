public class Solution {
    public int Jump(int[] nums) {
        
        var farthest = 0;
        var currentEnd = 0;
        var steps = 0;

        for(var i=0;i<nums.Length-1;i++){

            farthest = Math.Max(farthest, nums[i]+i);

            if(currentEnd == i){
                steps++;
                currentEnd = farthest;
            }

        }

        return steps;
    }
}

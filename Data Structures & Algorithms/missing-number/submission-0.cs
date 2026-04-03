public class Solution {
    public int MissingNumber(int[] nums) {

        var sum = 0;
        var correctSum = 0;

        foreach(var n in nums){
            sum += n;
        }

        for(var i=0;i<=nums.Length;i++){
            correctSum += i;
        }

        return correctSum-sum;
        
    }
}

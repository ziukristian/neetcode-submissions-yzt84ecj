public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        var res = new int[2];

        var left = 0;
        var right=numbers.Count()-1;

        while(left<right){
            var sum = numbers[left] + numbers[right];

            if(sum == target) return new int[]{left+1,right+1};

            if(sum>target){
                right--;
                continue;
            }

            if(sum<target){
                left++;
                continue;
            }
        }

        return res;
    }
}

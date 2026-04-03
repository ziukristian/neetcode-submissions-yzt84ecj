public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        Array.Sort(nums);

        var sol = new List<List<int>>();

        var l = nums.Length;

        for(var i=0;i<l;i++){

            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var left = i+1;
            var right = l-1;

            while(left<right){

                var c = nums[i] + nums[left] + nums[right];

                if(c == 0){
                    sol.Add(new List<int>(){nums[i],nums[left],nums[right]});
                    
                    left++;
                    right--;

                    // skip duplicates
                    while (left < right && nums[left] == nums[left - 1])
                        left++;

                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }

                if(c<0){
                    left++;
                }

                if(c>0){
                    right--;
                }


            }

            

        }

        return sol;
        
    }
}

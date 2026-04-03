public class Solution {
    public int MaxProduct(int[] nums) {
        
        var res = nums[0];
        var maxProd = nums[0];
        var minProd = nums[0];


        for(var i=1;i<nums.Length;i++){

            var n = nums[i];

            if(n<0){
                var temp = maxProd;
                maxProd = minProd;
                minProd = temp;
            }

            maxProd = Math.Max(n*maxProd,n);
            minProd = Math.Min(n*minProd,n);

            res = Math.Max(maxProd,res);

        }



        return res;
    }
}

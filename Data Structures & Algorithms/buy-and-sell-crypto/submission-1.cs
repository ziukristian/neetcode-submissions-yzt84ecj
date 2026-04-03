public class Solution {
    public int MaxProfit(int[] prices) {
        var minPrice = int.MaxValue;
        var maxProfit = 0;

        foreach(var p in prices){

            var potProfit = p - minPrice;

            maxProfit = Math.Max(potProfit,maxProfit);

            minPrice = Math.Min(minPrice,p);
        }

        return maxProfit;
    }
}

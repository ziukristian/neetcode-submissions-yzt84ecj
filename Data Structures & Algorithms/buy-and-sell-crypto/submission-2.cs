public class Solution {
    public int MaxProfit(int[] prices) {

        var max = 0;
        var lowest = int.MaxValue;

        foreach(var p in prices){
            max = Math.Max(max,p-lowest);

            lowest = Math.Min(lowest,p);
        }

        return max;
        
    }
}

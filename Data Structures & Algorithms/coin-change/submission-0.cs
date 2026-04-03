public class Solution {
    public int CoinChange(int[] coins, int amount) {
        
        var help = new int[amount+1];

        for (int i = 0; i < help.Length; i++) {
            help[i] = amount+1;
        }

        help[0] = 0;

        for(var i = 0;i<help.Length;i++){
            foreach(var c in coins){
                if(i-c >= 0){
                    help[i] = Math.Min(help[i],help[i-c] + 1);
                }
            }
        }

        return help[amount] > amount ? -1 : help[amount];
    }
}

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {

        int[,] dp = new int[text1.Length+1, text2.Length+1];

        var max = 0;

        for(var i=text1.Length-1;i>=0;i--){
            for(var j=text2.Length-1;j>=0;j--){

                if(text1[i] == text2[j]){
                    dp[i,j] = dp[i+1,j+1] + 1;
                    max = Math.Max(max,dp[i,j]);
                } else {
                    dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j + 1]);
                }

            }
        }

        return max;
        
    }
}

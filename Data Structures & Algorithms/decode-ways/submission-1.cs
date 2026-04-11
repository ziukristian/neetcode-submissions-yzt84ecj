public class Solution {
    public int NumDecodings(string s) {

        if(s[0] == '0') return 0;

        var dp = new int[s.Length+1];
        dp[s.Length] = 1;
        dp[s.Length-1] = s[s.Length-1] == '0' ? 0 : 1;

        for(var i = s.Length-2;i>=0;i--){

            var c = s[i];

            if(c=='0') {
                dp[i] = 0;
                continue;
            }

            dp[i] = dp[i+1];

            var prev = s[i+1];

            if(c=='1' || (c=='2' && prev != '7' && prev != '8' && prev != '9' )) dp[i] += dp[i+2];

        }


        return dp[0];
        
    }
}

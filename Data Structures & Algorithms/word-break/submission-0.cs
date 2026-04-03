public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {

        var dict = new HashSet<string>(wordDict);
        var n = s.Length;
        var dp = new bool[n+1];

        dp[0] = true;

        for(var i=1;i<=n;i++){

            foreach(var w in dict){
                var len = w.Length;
                if(i>=len && dp[i-len] && s.Substring(i-len,len) == w){
                    dp[i] = true;
                    break;
                }
            }

        }

        return dp[n];
        
    }
}

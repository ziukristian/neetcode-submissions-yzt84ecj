public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {

        var dict = new HashSet<string>(wordDict);
        
        var dp = new bool[s.Length+1];
        dp[0] = true;

        for(var i=1;i<s.Length+1;i++){
            for(var j=0;j<i;j++){
                if(!dp[j]) continue;

                var sub = s.Substring(j, i - j);

                if(dict.Contains(sub)){
                    dp[i] = true;
                    break;
                }

            }
        }

        return dp[s.Length];

    }
}

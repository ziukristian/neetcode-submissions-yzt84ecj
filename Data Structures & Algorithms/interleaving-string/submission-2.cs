public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {

        if (s1.Length + s2.Length != s3.Length)
            return false;

        var dp = new bool[s1.Length+1,s2.Length+1];

        dp[s1.Length,s2.Length] = true;

        for(var i = s1.Length; i>=0;i--){
            for(var j = s2.Length; j>=0;j--){
                if(j<s2.Length && s3[i+j] == s2[j] && dp[i,j+1]) dp[i,j] = true;
                if(i<s1.Length && s3[i+j] == s1[i] && dp[i+1,j]) dp[i,j] = true;
            }
        }

        return dp[0,0];
        
    }
}

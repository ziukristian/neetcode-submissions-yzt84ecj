public class Solution {
    public int LengthOfLongestSubstring(string s) {

        if(s == "") return 0;

        var sol = 0;

        var start = 0;
        var end = 0;

        var found = new HashSet<char>();

        while(end<s.Length){
            
            while(found.Contains(s[end])){
                found.Remove(s[start]);
                start++;
            }

            sol = Math.Max(sol,end-start);
            found.Add(s[end]);

            end++;

        }



        return sol+1;

    }
}

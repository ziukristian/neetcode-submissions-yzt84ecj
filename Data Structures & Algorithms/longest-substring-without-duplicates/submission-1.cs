public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Count() <= 1) return s.Count();

        var max = 1;
        var left = 0;
        var right = 0;

        var found = new HashSet<char>();

        while(right<s.Count()){
            if(found.Contains(s[right])){
                max = Math.Max(found.Count(),max);
                left++;
                right = left;
                found.Clear();
            } else {
                found.Add(s[right]);
                right++;
            }

            
        }

        return Math.Max(found.Count(),max);

    }
}

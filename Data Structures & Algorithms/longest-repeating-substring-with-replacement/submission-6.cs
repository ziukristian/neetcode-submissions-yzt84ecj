public class Solution {
    public int CharacterReplacement(string s, int k) {

        if(s.Length < 1) return s.Length;
        
        var left = 0;
        var right = 0;

        var max = 0;

        var count = new Dictionary<char,int>();

        while(right<s.Length){
            if(!count.ContainsKey(s[right])) count.Add(s[right],1);
            else count[s[right]]++;

            var windowLength = right-left+1;

            if(windowLength - count.Values.Max() <= k){
                right++;
                max = Math.Max(max,windowLength);
            } else {
                count[s[left]]--;
                if (count[s[left]] == 0) count.Remove(s[left]);
                left++;
                right++;
            }
        }

        return max;
    }
}

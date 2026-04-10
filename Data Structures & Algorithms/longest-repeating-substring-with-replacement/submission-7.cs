public class Solution {
    public int CharacterReplacement(string s, int k) {

        if(s.Length == 0 || s.Length == 1) return s.Length;

        var sol = 0;

        var left = 0;

        var freq = new int[26];

        var maxFreq = 0;

        for(var right = 0;right<s.Length;right++){

            freq[s[right]-'A']++;

            maxFreq = Math.Max(freq[s[right]-'A'],maxFreq);

            while(right - left + 1 - maxFreq > k){
                freq[s[left] - 'A']--;
                left++;
            }

            sol = Math.Max(sol, right - left + 1);

        }
        
         return sol;
    }
}

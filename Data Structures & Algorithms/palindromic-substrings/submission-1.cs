public class Solution {
    public int CountSubstrings(string s) {

        var counter = 0;
        
        for(var i = 0;i<s.Length;i++){

            var left = i;
            var right = i;

            while(left >= 0 && right<s.Length){
                if(s[left] == s[right]) counter++;
                else break;

                left--;
                right++;
            }

            left = i;
            right = i+1;

            while(left >= 0 && right<s.Length){
                if(s[left] == s[right]) counter++;
                else break;

                left--;
                right++;
            }
        }

        return counter;
        
    }
}

public class Solution {
    public string LongestPalindrome(string s) {

        string longest = "";

        for(var i=0;i<s.Length;i++){
            var even = expand(i,i+1);
            var odd = expand(i,i);

            var max = even.Length > odd.Length ? even : odd;

            longest = longest.Length > max.Length ? longest : max;
        }

        string expand(int left, int right){

            while(left>=0 && right<s.Length){
                if(s[left] != s[right]) break; 
                left--;
                right++;              
            }

            return s.Substring(left+1,right-left-1);
        }

        return longest;
        
    }
}

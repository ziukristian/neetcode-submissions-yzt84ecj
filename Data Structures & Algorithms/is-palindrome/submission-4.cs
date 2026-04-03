public class Solution {
    public bool IsPalindrome(string s) {

        var left = 0;
        var right = s.Length - 1;
        var lower = s.ToLower();

        while(left <= right){

            if(!char.IsLetterOrDigit(lower[left])){
                left++;
                continue;
            }

            if(!char.IsLetterOrDigit(lower[right])){
                right--;
                continue;
            }

            if(lower[left] != lower[right]) return false;

            left++;
            right--;
        }

        return true;
        
    }
}

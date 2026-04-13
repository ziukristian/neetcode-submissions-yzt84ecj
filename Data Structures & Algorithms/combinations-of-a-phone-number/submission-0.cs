public class Solution {
    public List<string> LetterCombinations(string digits) {
        
        var sol = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return sol;

        var dict = new Dictionary<char,string>();
        dict.Add('2', "abc");
        dict.Add('3', "def");
        dict.Add('4', "ghi");
        dict.Add('5', "jkl");
        dict.Add('6', "mno");
        dict.Add('7', "pqrs");
        dict.Add('8', "tuv");
        dict.Add('9', "wxyz");

        void backtrack(List<char> current, int start){
            
            if(current.Count == digits.Length){
                sol.Add(string.Concat(current));
                return;
            }

            var possibleChars = dict[digits[start]].ToArray();

            foreach(var c in possibleChars){
                current.Add(c);
                backtrack(current, start+1);
                current.RemoveAt(current.Count-1);
            }

        }

        backtrack(new List<char>(),0);


        return sol;
    }
}

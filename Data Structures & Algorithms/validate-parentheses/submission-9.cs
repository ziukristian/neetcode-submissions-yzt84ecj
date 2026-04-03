public class Solution {
    public bool IsValid(string s) {

        var st = new Stack<char>();

        var open = "{[(";
        var close = "]})";

        foreach(var c in s){
            if(open.Contains(c)){
                st.Push(c);
            }
            else {
                if(st.Count == 0) return false;
                
                var popped = st.Pop();

                if(c == '}' && popped != '{') return false;
                if(c == ']' && popped != '[') return false;
                if(c == ')' && popped != '(') return false;
            }
        }

        return st.Count == 0;
        
    }
}

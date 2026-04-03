public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach(var c in s){
            
            switch(c){
                case '{':
                    stack.Push(c);
                    break;
                case '[':
                    stack.Push(c);
                    break;
                case '(':
                    stack.Push(c);
                    break;
                case '}':
                    if(!stack.Any() || stack.Pop() != '{') return false;
                    break;
                case ']':
                    if(!stack.Any() || stack.Pop() != '[') return false;
                    break;
                case ')':
                    if(!stack.Any() || stack.Pop() != '(') return false;
                    break;
            }
        }

        return (!stack.Any());
    }
}

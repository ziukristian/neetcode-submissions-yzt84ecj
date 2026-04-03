public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

        foreach(var t in tokens){
            
            switch(t){
                case "+":
                    var a = stack.Pop();
                    var b = stack.Pop();
                    stack.Push(a+b);
                    break;
                case "-":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b-a);
                    break;
                case "*":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(a*b);
                    break;
                case "/":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b/a);
                    break;
                default:
                    stack.Push(int.Parse(t));
                    break;
            }

        }

        return stack.Pop();
        
    }
}

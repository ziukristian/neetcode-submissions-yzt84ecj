public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();

    foreach (var token in tokens) {
        if (int.TryParse(token, out int num)) {
            stack.Push(num);
        } else {
            int b = stack.Pop();
            int a = stack.Pop();
            int result = token switch {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => throw new InvalidOperationException("Unknown operator")
            };
            stack.Push(result);
        }
    }

    return stack.Pop();
    }
}

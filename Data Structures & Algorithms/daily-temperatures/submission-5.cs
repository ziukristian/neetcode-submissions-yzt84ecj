public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {

        var n = temperatures.Length;
        var res = new int[n];

        var stack = new Stack<int>();

        for(var i = n-1; i>=0; i--){

            while(stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i]){
                stack.Pop();
            }

            if(stack.Count != 0) res[i] = res[i] = stack.Peek() - i;

            stack.Push(i);

        }

        return res;
        
    }
}

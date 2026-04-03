public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Count();
        var stack = new Stack<int>();
        var res = new int[n];

        for(var i = 0;i<n;i++){

            while(stack.Any() && temperatures[i] > temperatures[stack.Peek()]){
                var prevIndex = stack.Pop();

                res[prevIndex] = i - prevIndex;

            }

            stack.Push(i);
        }

        return res;


    }
}

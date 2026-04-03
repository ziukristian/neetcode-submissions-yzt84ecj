public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var n = temperatures.Length;
        var res = new int[n];

        var s = new Stack<int>();

        for(var i = 0;i<n;i++){
            while(s.Any() && temperatures[s.Peek()] < temperatures[i]){
                res[s.Peek()] = i - s.Peek();
                s.Pop();
            }

            s.Push(i);
        }

        return res;
    }
}

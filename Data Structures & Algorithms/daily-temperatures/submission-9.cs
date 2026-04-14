public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        var mono = new Stack<int>();
        var n = temperatures.Length;

        var sol = new int[n];


        for(var i=n-1;i>=0;i--){

            while(mono.Count>0 && temperatures[mono.Peek()]<=temperatures[i]){
                mono.Pop();
            }

            if(mono.Count != 0) sol[i] = mono.Peek() - i;

            mono.Push(i);
        }

        return sol;
    }
}

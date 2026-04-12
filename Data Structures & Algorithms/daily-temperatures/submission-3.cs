public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {

        var stack = new Stack<int>();
        var sol = new int[temperatures.Length];


        for(var i = temperatures.Length-1;i>=0;i--){

            while(stack.Count() > 0 && temperatures[stack.Peek()] <= temperatures[i]){
                stack.Pop();
            }

            if(stack.Count() > 0){
                sol[i] = stack.Peek()-i;
            }
                       
            stack.Push(i);
        }


        return sol;
        
    }
}

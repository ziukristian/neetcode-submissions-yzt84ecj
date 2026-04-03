public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        var n = position.Count();
        
        var merged = position.Zip(speed, (p,s) => (Pos:p, Ttt: (decimal)(target-p)/s));

        var sortedMerge = merged.OrderByDescending( m => m.Pos);

        var stack = new Stack<decimal>();
        foreach(var m in sortedMerge){
            Console.WriteLine(m.ToString());
            Console.WriteLine(stack.Count().ToString());
            if(!stack.Any() || stack.Peek() < m.Ttt){
                Console.WriteLine("DENTRO");
                stack.Push(m.Ttt);
            }
        }

        return stack.Count();
    }
}

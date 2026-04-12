public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {

        var n = position.Length;
        var stack = new Stack<decimal>();

        var cars = new List<(int pos, int speed)>();

        for(int i = 0; i < n; i++)
            cars.Add((position[i], speed[i]));

        cars.Sort((a,b) => a.pos.CompareTo(b.pos));

        for(var i = n-1;i>=0;i--){

            decimal time = (decimal)(target-cars[i].pos)/cars[i].speed;

            if(stack.Count == 0 || time > stack.Peek())
                stack.Push(time);
                
        }

        return stack.Count();
        
    }
}

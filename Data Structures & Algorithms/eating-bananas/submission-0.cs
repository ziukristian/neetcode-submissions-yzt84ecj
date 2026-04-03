public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        var left = 1;
        var right = piles.Max();
        var sol = right;

        while(left<=right){
            int m = left + (right-left)/2;

            if(canWork(piles,h,m)) {
                sol = Math.Min(sol,m);
                right = m-1;
            } else {
                left = m+1;
            }


        }

        return sol;
    }

    public bool canWork(int[] piles, int h, int k){

        Console.WriteLine($"Checking {k}");

        int passed = 0;

        foreach(var pile in piles){

            passed += (int)Math.Ceiling((decimal)pile/k);

            if(passed > h) {
                Console.WriteLine($"FALSE");
                return false;
            }
        }

        Console.WriteLine($"TRUE");
        return true;
    }
}

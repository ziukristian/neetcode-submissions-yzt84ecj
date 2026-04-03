public class Solution {
    public int ClimbStairs(int n) {     
        if(n == 1) return 1;
        if(n == 2) return 2;

        var sol = new int[n];
        sol[0] = 1;
        sol[1] = 2;

        for(var i = 2; i<n; i++){
            sol[i] = sol[i-1] + sol[i-2];
        }

        return sol[n-1];
    }
}

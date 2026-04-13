public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int minK = 1;
        int maxK = piles.Max();

        while(minK < maxK){

            var hoursTaken = 0;
            var candidateK = minK + (maxK-minK)/2;

            foreach(var p in piles){
                hoursTaken += (p + candidateK - 1) / candidateK;
            }

            if(hoursTaken > h) {
                minK = candidateK + 1;
            } else maxK = candidateK;
        }

        return minK;

    }
}

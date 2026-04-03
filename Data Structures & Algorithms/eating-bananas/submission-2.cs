public class Solution {
     public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;                       // min possible speed
        int right = 0;                      

        // find the maximum pile
        foreach (var b in piles)
            right = Math.Max(right, b);

        int result = right;

        while (left <= right) {
            int mid = left + (right - left) / 2;   // candidate speed
            int hours = 0;

            foreach (var b in piles) {
                hours += (b + mid - 1) / mid;      // ceil division
            }

            if (hours <= h) {
                // mid speed works, try slower
                result = mid;
                right = mid - 1;
            } else {
                // mid speed too slow, try faster
                left = mid + 1;
            }
        }

        return result;
    }
}

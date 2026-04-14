public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        var prio = new PriorityQueue<int,int>();

        foreach(var n in nums){
            prio.Enqueue(n,n);

            while(prio.Count > k){
                prio.Dequeue();
            }
        }

        return prio.Dequeue();
    }
}

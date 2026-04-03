public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        var heap = new PriorityQueue<int,int>();

        foreach(var n in nums){
            heap.Enqueue(n,-n);
        }

        int res = 0;

        for(var i = 0;i<k-1;i++){
            heap.Dequeue();
        }

        return heap.Dequeue();
    }
}

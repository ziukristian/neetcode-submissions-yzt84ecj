public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        var heap = new PriorityQueue<int,int>();

        foreach(var stone in stones){
            heap.Enqueue(stone,-stone);
        }

        while(heap.Count > 1){
            var first = heap.Dequeue();
            var second = heap.Dequeue();

            var delta = first-second;

            if(delta != 0) {
                heap.Enqueue(delta,-delta);
            }
        }

        return heap.Count > 0 ? heap.Dequeue() : 0;
    }
}

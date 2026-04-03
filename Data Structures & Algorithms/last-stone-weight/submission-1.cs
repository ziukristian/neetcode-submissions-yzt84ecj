public class Solution {
    public int LastStoneWeight(int[] stones) {
        var heap = new PriorityQueue<int,int>();

        foreach(var s in stones){
            heap.Enqueue(s,-s);
        }

        while(heap.Count>1){
            var first = heap.Dequeue();
            var second = heap.Dequeue();

            var delta = first - second;

            if(delta > 0) {
                heap.Enqueue(delta,-delta);
            }
        }

        return heap.Count > 0 ? heap.Dequeue() : 0;
    }
}

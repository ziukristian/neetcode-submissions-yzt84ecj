public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        var prio = new PriorityQueue<int,int>();

        foreach(var s in stones){
            prio.Enqueue(s, -s);
        }

        while(prio.Count>1){

            var stone1 = prio.Dequeue();
            var stone2 = prio.Dequeue();

            if(stone1 == stone2) continue;

            prio.Enqueue(stone1-stone2, -(stone1-stone2));
        }

        return prio.Count > 0 ? prio.Dequeue() : 0;
    }
}

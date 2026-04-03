/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public int MinMeetingRooms(List<Interval> intervals) {

        if(intervals.Count == 0) return 0;

        intervals.Sort((a,b)=> a.start.CompareTo(b.start));

        var heap = new PriorityQueue<int,int>();

        heap.Enqueue(intervals[0].end,intervals[0].end);

        for(var i=1;i<intervals.Count;i++){
            if(intervals[i].start >= heap.Peek()){
                heap.Dequeue();
            }

            heap.Enqueue(intervals[i].end,intervals[i].end);
        }



        return heap.Count;

    }
}

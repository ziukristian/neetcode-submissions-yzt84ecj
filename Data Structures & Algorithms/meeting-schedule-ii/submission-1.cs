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
        var timeline = new List<(int time, int delta)>();

        foreach(var i in intervals){
            timeline.Add((i.start,1));
            timeline.Add((i.end,-1));
        }

        timeline.Sort((a,b)=>{
            return a.time == b.time ? a.delta.CompareTo(b.delta) : a.time.CompareTo(b.time);
        });

        var counter = 0;
        var max = 0;

        foreach(var t in timeline){
            counter += t.delta; 
            max = Math.Max(max,counter);
        }

        return max;
    }
}

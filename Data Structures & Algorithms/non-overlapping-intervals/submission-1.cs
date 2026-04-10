public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {

        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        var lastEnd = intervals[0][1];

        var min = 0;

        for(var i=1;i<intervals.Length;i++){
            var start = intervals[i][0];

            if(start < lastEnd) {
                min++;
                lastEnd = Math.Min(lastEnd,intervals[i][1]);
                continue;
            } else lastEnd = intervals[i][1];

            
        }

        return min;


        
    }
}

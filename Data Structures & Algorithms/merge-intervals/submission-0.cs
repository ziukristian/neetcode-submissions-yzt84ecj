public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        var sol = new List<int[]>();

        var i = 0;

        while(i<intervals.Length){
            var start = intervals[i][0];
            var end = intervals[i][1];

            while (i < intervals.Length && intervals[i][0] <= end)
            {
                end = Math.Max(end, intervals[i][1]);
                i++;
            }

            sol.Add(new int[] { start, end });
        }

        return sol.ToArray();
    }
}

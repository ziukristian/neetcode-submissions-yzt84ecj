public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        var prio = new PriorityQueue<int[], double>();


        foreach(var p in points){

            prio.Enqueue(p, -(Math.Sqrt(Math.Pow(p[0],2) + Math.Pow(p[1],2))));

            while(prio.Count > k){
                prio.Dequeue();
            }
        }

        var res = new List<int[]>();

        while(prio.Count > 0)
            res.Add(prio.Dequeue());

        return res.ToArray();
        
    }
}

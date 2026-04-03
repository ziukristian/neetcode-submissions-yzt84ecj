public class Solution {
    public int[][] KClosest(int[][] points, int k) {

        var heap = new PriorityQueue<int[],double>();

        foreach (int[] point in points)
        {
            int x = point[0];
            int y = point[1];

            double distance = Math.Sqrt(
                (0 - x) * (0 - x) +
                (0 - y) * (0 - y)
            );

            heap.Enqueue(point,distance);
        }

        var res = new int[k][];

        for(var i=0;i<k;i++){
            res[i] = heap.Dequeue();
        }

        return res;
        
    }
}

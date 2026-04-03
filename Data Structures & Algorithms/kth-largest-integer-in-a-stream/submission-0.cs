public class KthLargest {

    private PriorityQueue<int,int> q;
    private readonly int _k;

    public KthLargest(int k, int[] nums) {
        q = new PriorityQueue<int,int>();
        _k = k;

        foreach(var n in nums){
            q.Enqueue(n,n);
            if(q.Count > k){
                q.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        q.Enqueue(val,val);
        if(q.Count > _k){
            q.Dequeue();
        }
        return q.Peek();        
    }
}

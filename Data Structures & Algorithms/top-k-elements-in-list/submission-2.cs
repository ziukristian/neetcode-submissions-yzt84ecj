public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var q = new PriorityQueue<int,int>();
        var freq = new Dictionary<int,int>();
        
        
        foreach(var n in nums){
            if(freq.TryGetValue(n,out var times)){
                freq[n]++;
            } else freq[n] = 1;
        }

        foreach(var (key,val) in freq){
            q.Enqueue(key,-val);
        }

        var sol = new int[k];
        for(var i=0;i<k;i++){
            sol[i] = q.Dequeue();
        }

        return sol;
        
    }
}

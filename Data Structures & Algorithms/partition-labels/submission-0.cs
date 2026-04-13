public class Solution {
    public List<int> PartitionLabels(string s) {

        var dict = new Dictionary<char,int>();
        var sol = new List<int>();

        for(var i=0;i<s.Length;i++){
            dict[s[i]] = i;
        }

        var end = 0;
        var start = 0;

        for(var i=0;i<s.Length;i++){

            end = Math.Max(end, dict[s[i]]);

            if(i == end){
                sol.Add(end-start+1);
                start = i+1;
            }
        }

        return sol;
        
    }
}

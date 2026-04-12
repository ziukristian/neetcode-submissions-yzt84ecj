public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var result = new Dictionary<string,List<string>>();


        foreach(var s in strs){

            var ordered = new string(s.OrderBy(c => c).ToArray());

            if(result.TryGetValue(ordered, out var anagrams)){
                anagrams.Add(s);
            } else {
                result[ordered] = new List<string>(){s};
            }
        }

        return result.Values.ToList();
        
    }
}

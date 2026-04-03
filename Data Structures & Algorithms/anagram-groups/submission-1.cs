public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var dict = new Dictionary<string,List<string>>();

        foreach(var s in strs){
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            var key = new string(chars);

            if(dict.ContainsKey(key)) {
                dict[key].Add(s);
            } else {
                dict[key] = new List<string>{s};
            }
        }

        return dict.Values.ToList();
        
    }
}

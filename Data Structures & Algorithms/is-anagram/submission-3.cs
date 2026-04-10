public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var freq = new Dictionary<char,int>();

        foreach(char c in s){
            freq[c] = freq.TryGetValue(c, out int count) ? count + 1 : 1;
        }

        foreach(char c in t){
            if(!freq.TryGetValue(c, out int count)) return false;

            if(count == 1) freq.Remove(c);
            else freq[c]--;
        }

        return freq.Count == 0;

    }
}

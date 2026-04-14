public class Solution {
    public bool CheckInclusion(string s1, string s2) {

        if(s1.Length>s2.Length) return false;

        var s1Count = new int[26];
        var windowCount = new int[26];

        foreach(var c in s1){
            s1Count[c-'a']++;
        }

        for(var i=0;i<s1.Length;i++){
            windowCount[s2[i]-'a']++;
        }

        if(isSame(s1Count,windowCount)) return true;

        for(var i=s1.Length;i<s2.Length;i++){
            windowCount[s2[i]-'a']++;
            windowCount[s2[i-s1.Length]-'a']--;

            if(isSame(s1Count,windowCount)) return true;
        }

        return false;
        
    }

    public bool isSame(int[] a1, int[] a2){
        for(var i=0;i<a1.Length;i++){
            if(a1[i] != a2[i]) return false;
        }

        return true;
    }
}

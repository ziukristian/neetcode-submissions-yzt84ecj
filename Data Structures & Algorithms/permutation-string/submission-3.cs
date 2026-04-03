public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        var count = new Dictionary<char,int>();
        foreach (var c in s1) {
            if (!count.ContainsKey(c)) count[c] = 0;
            count[c]++;
        }

        int left = 0, right = 0;
        int toZero = count.Count;

        // Initialize first window
        for (; right < s1.Length; right++) {
            if (count.ContainsKey(s2[right])) {
                count[s2[right]]--;
                if (count[s2[right]] == 0) toZero--;
            }
        }

        if (toZero == 0) return true;

        // Slide window
        for (; right < s2.Length; right++, left++) {
            // Remove char leaving the window
            if (count.ContainsKey(s2[left])) {
                if (count[s2[left]] == 0) toZero++;
                count[s2[left]]++;
            }

            // Add new char entering the window
            if (count.ContainsKey(s2[right])) {
                count[s2[right]]--;
                if (count[s2[right]] == 0) toZero--;
            }

            if (toZero == 0) return true;
        }

        return false;
    }
}

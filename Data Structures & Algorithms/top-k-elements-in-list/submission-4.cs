public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var freq = new Dictionary<int, int>();

        // count frequencies
        foreach (var n in nums)
            freq[n] = freq.GetValueOrDefault(n, 0) + 1;

        // buckets: index = frequency
        var buckets = new List<int>[nums.Length + 1];

        for (int i = 0; i < buckets.Length; i++)
            buckets[i] = new List<int>();

        // place numbers into buckets
        foreach (var (num, count) in freq)
            buckets[count].Add(num);

        var result = new List<int>();

        // collect top k
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {
            foreach (var num in buckets[i]) {
                result.Add(num);
                if (result.Count == k)
                    break;
            }
        }

        return result.ToArray();

    }
}

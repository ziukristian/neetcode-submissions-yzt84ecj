public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {

        if(hand.Length % groupSize != 0) return false;

        Array.Sort(hand);
        var dict = new Dictionary<int,int>();

        foreach(var n in hand){
            dict[n] = dict.GetValueOrDefault(n) + 1;
        }

        foreach(var n in hand){
            if(dict[n] <= 0) continue;

            var counter = 0;
            while(counter < groupSize){
                if(dict.ContainsKey(n+counter) && dict[n+counter] > 0){
                    dict[n+counter]--;
                } else return false;

                counter++;
            }
        }

        return true;
        
    }
}

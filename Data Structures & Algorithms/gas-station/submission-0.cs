public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        var currentTank = 0;
        var totalTank = 0;
        var startIndex = 0;

        for(var i=0;i<gas.Length;i++){
            var gain = gas[i]-cost[i];

            totalTank += gain;
            currentTank += gain;

            if(currentTank < 0) {
                currentTank = 0;
                startIndex = i+1;
            }

        }

        return totalTank >= 0 ? startIndex : -1;
    }
}

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        

        var currentTank = 0;
        var totalTank = 0;
        var idx = 0;

        for(var i=0;i<gas.Length;i++){

            currentTank += gas[i] - cost[i];
            totalTank += gas[i] - cost[i];

            if(currentTank<0){
                currentTank = 0;
                idx = i+1;
            }
        }

        return totalTank<0 ? -1 : idx;
    }
}

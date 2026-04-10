public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {

        var rows = heights.Length;
        var cols = heights[0].Length;

        var flowMap = new FlowSource[rows,cols];

        // 1 pacific, 2 atlantic, 0 none, 3 both

        void flow(int r, int c, int sourceR, int sourceC, FlowSource source){
            if(r < 0 || c<0 || r>rows-1 || c>cols-1) return;

            if(heights[sourceR][sourceC] > heights[r][c]) return;

            if(source == flowMap[r,c]) return;

            if(flowMap[r,c] == FlowSource.NONE) {
                flowMap[r,c] = source;
            } else {
                flowMap[r,c] = FlowSource.BOTH;
            }

            var dirs = new (int,int)[]{(1,0),(0,1),(-1,0),(0,-1)};

            foreach(var d in dirs){
                flow(r+d.Item1,c+d.Item2,r,c,flowMap[r,c]);
            }
        }

        for(var i = 0;i<rows;i++){
            for(var j = 0;j<cols;j++){
                if(i == 0 || j == 0) flow(i,j,i,j,FlowSource.PACIFIC);

                if(i == rows-1 || j == cols-1) flow(i,j,i,j,FlowSource.ATLANTIC);
            }
        }

        var res = new List<List<int>>();

        for(var i = 0;i<rows;i++){
            for(var j = 0;j<cols;j++){
                if(flowMap[i,j] == FlowSource.BOTH) {
                    res.Add(new List<int>(){i,j});
                }
            }
        }

        return res;
        
    }

    enum FlowSource {
        NONE,
        PACIFIC,
        ATLANTIC,
        BOTH
    }
}

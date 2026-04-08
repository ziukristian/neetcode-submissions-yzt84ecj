public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {

        var map = new Dictionary<int,List<int>>();

        foreach(var p in prerequisites){
            if(map.TryGetValue(p[0], out var pre)){
                pre.Add(p[1]);
            } else {
                map[p[0]] = new List<int>(){p[1]};
            }
        }

        var visited = new int[numCourses];

        for(var i=0;i<numCourses;i++){
            if(!canTake(i)) return false;
        }

        return true;

        bool canTake(int c){

            if(visited[c] == 1) return false;
            if(visited[c] == 2) return true;

            if(!map.ContainsKey(c)) {
                visited[c] = 2;
                return true;
            }

            var pre = map[c];

            visited[c] = 1;

            foreach(var p in pre){
                if(!canTake(p)) return false;
            }

            visited[c] = 2;

            return true;

        }
        
    }
}

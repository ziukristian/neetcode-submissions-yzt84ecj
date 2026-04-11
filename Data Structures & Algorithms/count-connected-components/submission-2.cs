public class Solution {
    public int CountComponents(int n, int[][] edges) {

        var components = 0;

        var adj = new Dictionary<int,List<int>>();

        foreach(var e in edges){
            if(adj.TryGetValue(e[0], out var list)){
                list.Add(e[1]);
            } else {
                adj[e[0]] = new List<int>(){e[1]};
            }

            if(adj.TryGetValue(e[1], out var list2)){
                list2.Add(e[0]);
            } else {
                adj[e[1]] = new List<int>(){e[0]};
            }
        }

        bool[] visited = new bool[n];

        bool dfs(int node){

            if(visited[node]) return false;

            visited[node] = true;

            if(adj.TryGetValue(node, out var list)){
                foreach(var neighbor in list){
                    dfs(neighbor);
                }
            }

            return true;

        }

        for(var i = 0;i<n;i++){
            if(dfs(i)) components++;
        }

        return components;
    }
}

public class Solution {
    public bool ValidTree(int n, int[][] edges) {

        if(edges.Length != n-1) return false;

        var adj = new Dictionary<int,List<int>>();

        foreach(var e in edges){
            if(adj.TryGetValue(e[0],out var neighbors)) neighbors.Add(e[1]);
            else adj[e[0]] = new List<int>(){e[1]};

            if(adj.TryGetValue(e[1],out var neighbors2)) neighbors2.Add(e[0]);
            else adj[e[1]] = new List<int>(){e[0]};
        }

        var visited = new bool[n];

        dfs(0);

        foreach(var v in visited){
            if(!v) return false;
        }

        return true;

        void dfs(int node){
            if(visited[node]) return;

            visited[node] = true;

            if(!adj.ContainsKey(node)) return;

            foreach(var neighbor in adj[node]){
                dfs(neighbor);
            }
        }

    }
}

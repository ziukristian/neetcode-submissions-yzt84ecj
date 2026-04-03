public class Solution {
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;

        int[][] MakeVisited() {
            var v = new int[rows][];
            for (int i = 0; i < rows; i++)
                v[i] = new int[cols];
            return v;
        }

        bool Backtrack(int[][] visited, int c, int x, int y) {
            if (c == word.Length) return true;
            if (x < 0 || x >= rows || y < 0 || y >= cols) return false;
            if (board[x][y] != word[c] || visited[x][y] == 1) return false;

            visited[x][y] = 1;

            bool found =
                Backtrack(visited, c + 1, x + 1, y) ||
                Backtrack(visited, c + 1, x - 1, y) ||
                Backtrack(visited, c + 1, x, y + 1) ||
                Backtrack(visited, c + 1, x, y - 1);

            visited[x][y] = 0; // undo

            return found;
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                var visited = MakeVisited();
                if (Backtrack(visited, 0, i, j)) return true;
            }
        }

        return false;
    }
}

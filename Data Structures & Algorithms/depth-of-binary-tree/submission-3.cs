/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root) {
        
        var max = 0;

        void dfs(TreeNode node, int currentDepth){
            if(node is null) return;

            currentDepth++;

            max = Math.Max(max,currentDepth);

            dfs(node.left,currentDepth);
            dfs(node.right,currentDepth);
        }

        dfs(root, 0);

        return max;

    }
}

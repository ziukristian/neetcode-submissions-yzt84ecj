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

        void dfs(TreeNode node, int d){

            if(node is null) return;

            max = Math.Max(max,d);

            dfs(node.left,d+1);
            dfs(node.right,d+1);
        }

        dfs(root,1);


        return max;
        
    }
}

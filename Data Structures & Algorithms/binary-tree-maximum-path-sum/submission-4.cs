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
    public int MaxPathSum(TreeNode root) {

        int max = int.MinValue;

        int dfs(TreeNode node){
            if(node is null) return 0;

            var left = Math.Max(0,dfs(node.left));
            var right = Math.Max(0,dfs(node.right));

            max = Math.Max(max,left+right+node.val);

            return node.val+Math.Max(left,right);
        }

        dfs(root);

        return max;

    }
}

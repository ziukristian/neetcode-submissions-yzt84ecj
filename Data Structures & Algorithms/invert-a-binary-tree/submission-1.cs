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
    public TreeNode InvertTree(TreeNode root) {
        

        void dfs(TreeNode node){
            if(node is null) return;

            dfs(node.left);
            dfs(node.right);

            var temp = node.left;
            node.left = node.right;
            node.right = temp;
        }

        dfs(root);

        return root;
    }
}

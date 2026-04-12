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
    public int DiameterOfBinaryTree(TreeNode root) {
        
        var max = 0;


        int traverse(TreeNode node){
            if(node is null) return 0;

            var left = traverse(node.left);
            var right = traverse(node.right);

            max = Math.Max(max,left+right);

            return Math.Max(left,right) + 1;
        }

        traverse(root);
        return max;

        
    }
}

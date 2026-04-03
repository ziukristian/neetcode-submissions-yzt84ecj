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
    public bool IsBalanced(TreeNode root) {

        var unbalanced =false;

        int traverse(TreeNode node){
            if(node is null || unbalanced) return 0;

            var leftHeight = traverse(node.left);
            var rightHeight = traverse(node.right);

            if(Math.Abs(leftHeight-rightHeight) > 1) unbalanced = true;

            return 1 + Math.Max(leftHeight,rightHeight );
        }

        traverse(root);

        return !unbalanced;
        
    }
}

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

    public bool IsValidBST(TreeNode root) {
        
        bool traverse(TreeNode node, int min, int max){
            if(node is null) return true;

            if(node.val <= min || node.val >= max) return false;

            return traverse(node.left, min, node.val) && traverse(node.right,node.val,max);
        }

        return traverse(root,int.MinValue,int.MaxValue);
    }
}

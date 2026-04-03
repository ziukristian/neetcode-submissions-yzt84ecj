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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {

        if(root is null) return false;

        if(isSame(root,subRoot)) return true;

        bool isSame(TreeNode node, TreeNode root){
            if(node is null && root is null) return true;

            if(node == null || root == null) return false;

            if(node.val != root.val) return false;

            return isSame(node.left,root.left) && isSame(node.right,root.right);
        }

        return IsSubtree(root.left,subRoot) ||  IsSubtree(root.right,subRoot);
        
    }
}

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
        return check(root) != -1;
    }

    public int check(TreeNode node){
        if (node == null) return 0;

        int left = check(node.left);
        if (left == -1) return -1;

        int right = check(node.right);
        if (right == -1) return -1;

        if (Math.Abs(left - right) > 1)
            return -1;

        return Math.Max(left, right) + 1;
    }
}

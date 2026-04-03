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
    public int KthSmallest(TreeNode root, int k) {

        int? sol = null;
        int count = 0;

        void traverse(TreeNode node){
            if(node is null || sol is not null) return;

            traverse(node.left);

            count++;
            if(count == k) sol = node.val;

            traverse(node.right);
        }

        traverse(root);

        return sol!.Value;
        
    }
}

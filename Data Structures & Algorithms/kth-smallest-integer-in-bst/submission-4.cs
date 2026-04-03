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

        int sol = 0;
        int count = 0;

        void traverse(TreeNode node){
            if(node is null) return;

            traverse(node.left);

            if(++count == k) {
                sol = node.val;
                return;
            }

            traverse(node.right);
        }

        traverse(root);

        return sol;
        
    }
}

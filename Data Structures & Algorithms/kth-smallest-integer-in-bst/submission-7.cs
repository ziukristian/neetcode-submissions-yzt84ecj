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

        var counter = 0;
        int sol = 0;

        void dfs(TreeNode node){

            if(counter == k || node is null) return;

            dfs(node.left);

            counter++;
            if(counter == k) {
                sol = node.val;
                return;
            }

            dfs(node.right);

            
        }

        dfs(root);

        return sol;
        
    }
}

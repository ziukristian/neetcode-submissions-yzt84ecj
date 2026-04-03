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

        int res = root.val;
        int counter = 0;


        void dfs(TreeNode node){
            if(node is null) return;

            dfs(node.left);

            counter++;

            if(counter == k){
                res = node.val;
            }
            
            dfs(node.right);


        }

        dfs(root);

        return res;
        
    }
}

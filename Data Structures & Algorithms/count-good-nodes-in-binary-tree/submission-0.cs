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
    public int GoodNodes(TreeNode root) {

        if(root is null) return 0;

        var res = 0;

        void traverse(TreeNode node, int max){

            if(node is null) return;

            if(node.val >= max){
                res++;
                max = node.val;
            }

            traverse(node.left, max);
            traverse(node.right, max);
        }

        traverse(root, -101);
        return res;
        
    }
}

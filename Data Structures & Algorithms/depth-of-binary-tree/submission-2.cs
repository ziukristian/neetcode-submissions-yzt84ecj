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
    public int MaxDepth(TreeNode root) {
        

        var max = 0;


        void dfs(TreeNode main, int current){
            if(main is null) return;

            max = Math.Max(max,current);

            dfs(main.left, current+1);
            dfs(main.right, current+1);
        }

        dfs(root,1);


        return max;
    }
}

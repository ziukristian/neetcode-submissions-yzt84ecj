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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {

        var inorderIndex = new Dictionary<int,int>();
        for (int i = 0; i < inorder.Length; i++) {
            inorderIndex[inorder[i]] = i;
        }
        
        TreeNode build(int startPre, int endPre, int startIn, int endIn){

            if (startPre > endPre || startIn > endIn) return null;

            var val = preorder[startPre];

            TreeNode root = new TreeNode(val);

            int i = inorderIndex[val];

            int leftSize = i - startIn; // number of nodes in left subtree
            root.left  = build(startPre + 1, startPre + leftSize, startIn, i - 1);
            root.right = build(startPre + leftSize + 1, endPre, i + 1, endIn);

            return root;

        }


        return build(0, preorder.Length - 1, 0, inorder.Length - 1);
        
    }
}

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


        TreeNode traverse(ReadOnlySpan<int> preorder,ReadOnlySpan<int> inorder){
            if(preorder.Length == 0) return null;

            var root = new TreeNode(preorder[0]);

            var i = inorder.IndexOf(root.val);

            root.left = traverse(preorder.Slice(1,i), inorder.Slice(0,i));
            root.right = traverse(preorder.Slice(i+1), inorder.Slice(i+1));

            return root;
        }

        return traverse(preorder.AsSpan(),inorder.AsSpan());
        
    }
}

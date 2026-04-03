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

        var heap = new PriorityQueue<int,int>();

        void traverse(TreeNode node){
            if(node is null) return;

            heap.Enqueue(node.val,-node.val);

            while(heap.Count > k) {
                heap.Dequeue();
            }

            traverse(node.left);
            traverse(node.right);
        }

        traverse(root);

        return heap.Dequeue();
        
    }
}

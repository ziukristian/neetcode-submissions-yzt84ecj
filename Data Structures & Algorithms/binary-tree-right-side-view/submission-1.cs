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
    public List<int> RightSideView(TreeNode root) {

        var res = new List<int>();

        if(root is null) return res;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Any()){

            var levelSize = q.Count;
            for(var i = 0;i<levelSize;i++){
                var w = q.Dequeue();
                if(w.left is not null) q.Enqueue(w.left);
                if(w.right is not null) q.Enqueue(w.right);

                if(i == levelSize-1){
                    res.Add(w.val);
                }
            }
        }

        return res;
        
    }
}

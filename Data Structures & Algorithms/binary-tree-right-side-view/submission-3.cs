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
            TreeNode work;
            var c = q.Count();
            for(var i =0;i<c-1;i++){
                work = q.Dequeue();
                if(work.left is not null) q.Enqueue(work.left);
                if(work.right is not null) q.Enqueue(work.right);
            }

            work = q.Dequeue();

            res.Add(work.val);

            if(work.left is not null) q.Enqueue(work.left);
            if(work.right is not null) q.Enqueue(work.right);
        }



        return res;
        
    }
}

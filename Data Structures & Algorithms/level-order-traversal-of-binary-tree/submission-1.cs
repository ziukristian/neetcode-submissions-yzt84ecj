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
    public List<List<int>> LevelOrder(TreeNode root) {
        

        var sol = new List<List<int>>();

        if(root is null) return sol;

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            var l = q.Count;

            var level = new List<int>();
            for(var i=0;i<l;i++){
                var toWork = q.Dequeue();
                level.Add(toWork.val);

                if(toWork.left is not null) q.Enqueue(toWork.left);
                if(toWork.right is not null) q.Enqueue(toWork.right);
            }

            sol.Add(level);
        }

        return sol;
        
    }
}

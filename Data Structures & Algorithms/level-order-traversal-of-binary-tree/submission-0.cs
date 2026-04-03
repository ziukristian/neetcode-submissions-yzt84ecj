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
        var res = new List<List<int>>();

        if(root is null) return res;

        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);

        while(queue.Any()){

            var levelList = new List<int>();
            var levelSize = queue.Count;
            for(var i = 0;i<levelSize;i++){

                var worked = queue.Dequeue();
                if(worked.left is not null) queue.Enqueue(worked.left);
                if(worked.right is not null) queue.Enqueue(worked.right);
                levelList.Add(worked.val);
            }

            res.Add(levelList);
        }
        
        return res;
    }
}

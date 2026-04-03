/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     constructor(val = 0, left = null, right = null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

class Solution {
    /**
     * @param {TreeNode} root
     * @return {number}
     */
    maxDepth(root) {

        if(!root) return 0
        let ld = this.maxDepth(root.left)
        let rd = this.maxDepth(root.right)
        let depth = 1 + (ld > rd ? ld : rd)

        return depth

    }

}

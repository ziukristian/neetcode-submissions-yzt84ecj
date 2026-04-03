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
     * @param {TreeNode} p
     * @param {TreeNode} q
     * @return {boolean}
     */
    isSameTree(p, q) {

        return this.traverse(p,"") == this.traverse(q,"")

    }

    traverse(root,code){
        if(!root) return "-"

        let newCode = code + root.val

        return newCode + this.traverse(root.left, newCode) + this.traverse(root.right, newCode)
    }
}

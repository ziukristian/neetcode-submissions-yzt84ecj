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
     * @return {boolean}
     */
    isBalanced(root) {
        let res = [true]
        this.traverse(root,res)
        return res[0]

    }

    traverse(root,res){
        console.log("ATTRAVERSO: ",root)
        if(!root) return 0

        let dl = this.traverse(root.left,res)
        let dr = this.traverse(root.right,res)

        if(Math.abs(dl-dr) > 1) res[0] = false

        return 1 + (dl > dr ? dl : dr)
    }
}

/**
 * Definition for singly-linked list.
 * class ListNode {
 *     constructor(val = 0, next = null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

class Solution {
    /**
     * @param {ListNode} head
     * @return {boolean}
     */
    hasCycle(head) {
        if(!head) return false
        let visited = new Set()
        let curr = head

        while(curr.next){
            if(visited.has(curr)) return true

            visited.add(curr)
            curr = curr.next
        }

        return false
    }
}

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
     * @param {ListNode} list1
     * @param {ListNode} list2
     * @return {ListNode}
     */
    mergeTwoLists(list1, list2) {
        if(!list1) return list2
        if(!list2) return list1

        let head = null
        let c1 = null
        let c2 = null
        let curr = null

        if(list1.val <= list2.val){
            head = list1
            c1 = list1.next
            c2 = list2
        }
        else {
            head = list2
            c2 = list2.next
            c1 = list1
        }
        curr = head

        while(true){
            if(!c2){
                curr.next = c1
                return head
            }

            if(!c1){
                curr.next = c2
                return head
            }

            if(c1.val <= c2.val){
                curr.next = c1
                curr = c1
                c1 = c1.next
            }
            else {
                curr.next = c2
                curr = c2
                c2 = c2.next
            }
        }
    }
}

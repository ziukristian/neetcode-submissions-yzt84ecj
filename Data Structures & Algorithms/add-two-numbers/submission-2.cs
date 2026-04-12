/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        var rem = 0;

        var dummy = new ListNode();
        var current = dummy;


        while(l1 != null || l2 != null || rem!=0){

            var localSum = rem + (l1 is null ? 0 : l1.val) + (l2 is null ? 0 : l2.val);

            rem = localSum / 10;

            current.next = new ListNode(localSum % 10);
            current = current.next;

            if(l1 is not null) l1 = l1.next;
            if(l2 is not null) l2 = l2.next;

        }

        return dummy.next;
        
    }
}

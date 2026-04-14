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
    public void ReorderList(ListNode head) {

        if(head is null || head.next is null) return;
        
        var slow = head;
        var fast = head;

        while(fast is not null && fast.next is not null){
            slow = slow.next;
            fast = fast.next.next;
        }

        var current = slow.next;
        ListNode prev = null;

        while(current is not null){
            var temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }

        slow.next = null;
        var head1 = head;
        var head2 = prev;

        while(head2 is not null){

            var temp = head1.next;
            var temp2 = head2.next;
            head1.next = head2;
            head2.next = temp;

            head1 = temp;
            head2 = temp2;
        }

        return;



        
    }
}

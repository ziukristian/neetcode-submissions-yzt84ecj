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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        var dummy = new ListNode(0, head);

        var slow = dummy;
        var fast = dummy;

        // move fast n+1 steps
        for (int i = 0; i <= n; i++)
        {
            fast = fast.next;
        }

        // move both pointers
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        // remove node
        slow.next = slow.next.next;

        return dummy.next;
    }
}

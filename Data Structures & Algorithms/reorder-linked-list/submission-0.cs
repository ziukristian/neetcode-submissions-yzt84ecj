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

        if (head == null || head.next == null)
            return;

        var list = new List<ListNode>();
        var current = head;

        while (current != null) {
            list.Add(current);
            current = current.next;
        }

        int left = 1;
        int right = list.Count - 1;
        current = head;

        while (left <= right) {
            current.next = list[right];
            current = current.next;
            right--;

            if (left <= right) {
                current.next = list[left];
                current = current.next;
                left++;
            }
        }

        current.next = null;
        
    }
}
